using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task2Library;

namespace task2Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string path = openFileDialog1.FileName;
            
            File file = new File(path);
            
            //string path = @"C:\Users\andrey\RiderProjects\IT_Tasks\task2\TestText.txt";
            Dictionary<int, int> result = file.task2();
            int tmp = 0;
            if (result != null)
            {
                dataGridView1.Columns.Add("", "");
                dataGridView1.Columns.Add("", "");



                foreach (int key in result.Keys)
                {
                    
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[tmp].Cells[0].Value = key.ToString();
                    dataGridView1.Rows[tmp].Cells[1].Value = result[key].ToString();
                    tmp++;

                }
            }
        }
    }
}