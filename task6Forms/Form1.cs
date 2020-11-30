using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task6;

namespace task6Forms
{
    public partial class Form1 : Form
    {
        private List<MusicalInstrument> MusicalInstruments { get; }
        private  DataGridViewTextBoxColumn NameColumn { get; set; }
        private DataGridViewColumn ButtonColumn { get; set; }


        public Form1()
        {
            MusicalInstruments = new List<MusicalInstrument>();
            InitializeComponent();
            AddColumns();
        }

        private void addInstrumentButton_Click(object sender, EventArgs e)
        {
            MusicalInstrument instrument = new ElectricGuitar();
            instrument.Name = InstrumentName.Text;
            MusicalInstruments.Add(instrument);
            AddRow(instrument);
        }

        public void AddRow(MusicalInstrument instrument)
        {
            DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            cell.Value = instrument.Name;
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(cell);
            row.Cells.Add(buttonCell);
            listInstruments.Rows.Add(row);
        }

        private void AddColumns()
        { 
            NameColumn = new  DataGridViewTextBoxColumn();
            NameColumn.Name = "Task";
            NameColumn.DataPropertyName = "Id";
            NameColumn.ReadOnly = true;
            
            // DataGridViewComboBoxColumn assignedToColumn = new DataGridViewComboBoxColumn();
            //
            // assignedToColumn.Items.Add("unassigned");
            // assignedToColumn.DefaultCellStyle.NullValue = "unassigned";
            //
            // assignedToColumn.Name = "Assigned To";
            // assignedToColumn.DataPropertyName = "AssignedTo";
            // assignedToColumn.AutoComplete = true;
            // assignedToColumn.DisplayMember = "Name";
            // assignedToColumn.ValueMember = "Self";

            // Add a button column. 
            ButtonColumn = new DataGridViewButtonColumn();
            ButtonColumn.HeaderText = "";
            ButtonColumn.Name = "Status Request";


            listInstruments.Columns.Add(NameColumn);
            // listInstruments.Columns.Add(assignedToColumn);
            listInstruments.Columns.Add(ButtonColumn);

            // // Add a CellClick handler to handle clicks in the button column.
            // listInstruments.CellClick +=
            //     new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }
        
        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex !=
                listInstruments.Columns["Status Request"].Index) return;

            // Retrieve the task ID.
            Int32 taskID = (Int32) listInstruments[0, e.RowIndex].Value;

            // Retrieve the Employee object from the "Assigned To" cell.
            object assignedTo = listInstruments.Rows[e.RowIndex]
                .Cells["Assigned To"].Value;

            // Request status through the Employee object if present. 
            // if (assignedTo != null)
            // {
                // assignedTo.RequestStatus(taskID);
            // }
            // else
            {
                MessageBox.Show(String.Format(
                    "Task {0} is unassigned.", taskID), "Status Request");
            }
        }
    }
    
}