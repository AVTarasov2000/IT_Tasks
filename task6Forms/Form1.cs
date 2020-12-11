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
        private DataGridViewColumn PlayButtonColumn { get; set; }
        private DataGridViewColumn TuneButtonColumn { get; set; }
        private DataGridViewColumn RemoveButtonColumn { get; set; }


        public Form1()
        {
            MusicalInstruments = new List<MusicalInstrument>();
            InitializeComponent();
            AddColumns();
            addInstrument("Cort-guitar");
            addInstrument("Marshal-guitar");
        }

        private void addInstrumentButton_Click(object sender, EventArgs e)
        {
            addInstrument(InstrumentName.Text);
        }

        private void addInstrument(string name)
        {
            Guitar instrument = new ElectricGuitar();
            instrument.Name = name;
            MusicalInstruments.Add(instrument);
            instrument.onConsoleWrite += MessageWriter;
            AddRow(instrument);
        }

        public void AddRow(MusicalInstrument instrument)
        {
            DataGridViewButtonCell deleteButtonCell = new DataGridViewButtonCell();
            deleteButtonCell.Value = "delete";
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            cell.Value = instrument.Name;
            DataGridViewButtonCell playButtonCell = new DataGridViewButtonCell();
            playButtonCell.Value = "Play";
            DataGridViewButtonCell tuneButtonCell = new DataGridViewButtonCell();
            tuneButtonCell.Value = "Tune";
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(deleteButtonCell);
            row.Cells.Add(cell);
            row.Cells.Add(playButtonCell);
            row.Cells.Add(tuneButtonCell);
            listInstruments.Rows.Add(row);
        }

        private void AddColumns()
        {
            listInstruments.AutoSize = true;
            
            RemoveButtonColumn = new DataGridViewButtonColumn();
            RemoveButtonColumn.HeaderText = "";
            RemoveButtonColumn.Name = "Remove method";
            
            NameColumn = new  DataGridViewTextBoxColumn();
            NameColumn.Name = "Name";
            NameColumn.DataPropertyName = "Id";
            NameColumn.ReadOnly = true;
            
            PlayButtonColumn = new DataGridViewButtonColumn();
            PlayButtonColumn.HeaderText = "";
            PlayButtonColumn.Name = "Play method";
            
            TuneButtonColumn = new DataGridViewButtonColumn();
            TuneButtonColumn.HeaderText = "";
            TuneButtonColumn.Name = "Tune method";
            
            listInstruments.Columns.Add(RemoveButtonColumn);
            listInstruments.Columns.Add(NameColumn);
            listInstruments.Columns.Add(PlayButtonColumn);
            listInstruments.Columns.Add(TuneButtonColumn);
            
            listInstruments.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex < 0) return;

            if(e.ColumnIndex == listInstruments.Columns["Play method"].Index)
                MusicalInstruments[e.RowIndex].Play();
            else if (e.ColumnIndex == listInstruments.Columns["Tune method"].Index)
                MusicalInstruments[e.RowIndex].Tune();
            else if (e.ColumnIndex == listInstruments.Columns["Remove method"].Index)
            {
                MusicalInstruments.RemoveAt(e.RowIndex);
                listInstruments.Rows.RemoveAt(e.RowIndex);
            }
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