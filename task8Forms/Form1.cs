using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task8Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint;
        }
        
        private void panel1_Paint( object sender, PaintEventArgs e )
        {
            var p = sender as Panel;
            var g = e.Graphics;

            g.FillRectangle( new SolidBrush( Color.FromArgb( 0, Color.Black ) ), p.DisplayRectangle );

            Point[] points = new Point[4];

            points[0] = new Point( 0, 0 );
            points[1] = new Point( 0, p.Height-200 );
            points[2] = new Point( p.Width, p.Height-200);
            points[3] = new Point( p.Width, 0 );

            Brush brush = new SolidBrush( Color.DarkGreen );

            g.FillPolygon( brush, points );
        }
    }
}