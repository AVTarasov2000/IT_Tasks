﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4Forms
{
    public partial class Form1 : Form
    {
        private task4.Hous Hous;
        private task4.Hous2 Hous2;
        
        public Form1()
        {
            InitializeComponent();
            Hous = new task4.Hous();
            Hous2 = new task4.Hous2();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hous.BildYear = (int) numericHous1.Value;
            Hous.CountOfFlats = (int) numericHous2.Value;
            Hous.NumberOfHous = (int) numericHous3.Value;
            res1.Text = Hous.GetQ((int) yearNow.Value).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hous2.BildYear = (int) numericHous1.Value;
            Hous2.CountOfFlats = (int) numericHous2.Value;
            Hous2.NumberOfHous = (int) numericHous3.Value;
            res2.Text = Hous2.GetQ((int) yearNow.Value).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}