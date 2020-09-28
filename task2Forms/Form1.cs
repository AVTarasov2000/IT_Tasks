using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            string path = @"C:\Users\andrey\RiderProjects\IT_Tasks\task2\TestText.txt";
            Dictionary<int, int> result = task2.Program.task2(task2.Program.getFileContent(path));
            int tmp = 0;
            if (result != null)
            {
                dataGridView1.Columns.Add("", "");
                dataGridView1.Columns.Add("", "");



                foreach (int key in result.Keys)
                {
                    
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[tmp].Cells[0].Value = key.ToString();
                    dataGridView1.Rows[tmp].Cells[1].Value = key.ToString();
                    tmp++;

                }
            }
        }
    }
}