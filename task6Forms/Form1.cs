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
            Guitar instrument = new ElectricGuitar();
            instrument.Name = InstrumentName.Text;
            MusicalInstruments.Add(instrument);
            instrument.onConsoleWrite += MessageWriter;
            AddRow(instrument);
        }

        public void AddRow(MusicalInstrument instrument)
        {
            DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
            buttonCell.Value = "button";
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
            
            ButtonColumn = new DataGridViewButtonColumn();
            ButtonColumn.HeaderText = "";
            ButtonColumn.Name = "Start method";
            
            listInstruments.Columns.Add(NameColumn);
            listInstruments.Columns.Add(ButtonColumn);

            // Add a CellClick handler to handle clicks in the button column.
            listInstruments.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex < 0 || e.ColumnIndex != listInstruments.Columns["Start method"].Index) return;
            MusicalInstruments[e.RowIndex].Play();
        }

        public void MessageWriter(string message)
        {
            MessageBox.Show(
                message, 
                "Сообщение", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button1, 
                MessageBoxOptions.DefaultDesktopOnly);
        }
    }
    
}