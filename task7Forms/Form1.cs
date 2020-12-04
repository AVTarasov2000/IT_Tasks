using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task7Library;

namespace task7Forms
{
    public partial class Form1 : Form
    {
        public ClassLooker ClassLooker { get; set; }
        public Type SelectedType { get; set; }
        
        public object SelectedTypeObj { get; set; }
        
        public Form1()
        {
            ClassLooker = new ClassLooker(@"C:\Users\Andrey\RiderProjects\IT_Tasks\task6Forms\bin\Debug\task6Library.dll");
            InitializeComponent();
            foreach (var type in ClassLooker.AllAbstractClassesAndInterfaces())
            {
                listBox1.Items.Add(type.Name);
            }
            
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = openFileDialog1.FileName;
            ClassLooker = new ClassLooker(filename);
            foreach (var type in ClassLooker.AllAbstractClassesAndInterfaces())
            {
                listBox1.Items.Add(type.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Clear();
                foreach (var allChildrenAndImpl in ClassLooker.AllChildrenAndImpls(ClassLooker.GetType(listBox1.SelectedItem.ToString())))
                {
                    listBox2.Items.Add(allChildrenAndImpl.Name);
                }
            }
        }
        
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                dataGridView1.Rows.Clear();
                SelectedType = ClassLooker.GetType(listBox2.SelectedItem.ToString());
                SelectedTypeObj = Activator.CreateInstance(SelectedType);
                foreach (var methodInfo in SelectedType.GetMethods())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    cell.Value = methodInfo.Name;
                    row.Cells.Add(cell);
                    dataGridView1.Rows.Add(row);
                }
            }
        }
        
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ButtonColumn"].Index)
            {
                List<Object> objects = new List<object>();
                MethodInfo methodInfo = SelectedType.GetMethods()[e.RowIndex];
                foreach (var parameterInfo in methodInfo.GetParameters())
                {
                    objects.Add(null);
                }

                object res = methodInfo.Invoke(SelectedTypeObj, objects.ToArray());
                MessageBox.Show((string)res);
            }
        }
        
    }
}