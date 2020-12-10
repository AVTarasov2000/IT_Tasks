using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using task8Library;

namespace task8Forms
{
    public partial class Form1 : Form
    {
        private Emulation _emulation;
        private Thread _repaintThread = null;
        public Form1()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            var g = e.Graphics;

            g.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);

            if (_emulation==null)
            {
                return;
            }
            foreach (var emulationTrolleyBuss in _emulation.TrolleyBusses)
            {
                Point[] points = new Point[4];

                points[0] = new Point(emulationTrolleyBuss.MyCoordinates.X, emulationTrolleyBuss.MyCoordinates.Y);
                points[1] = new Point(emulationTrolleyBuss.MyCoordinates.X, emulationTrolleyBuss.MyCoordinates.Y+5);
                points[2] = new Point(emulationTrolleyBuss.MyCoordinates.X+5, emulationTrolleyBuss.MyCoordinates.Y+5);
                points[3] = new Point(emulationTrolleyBuss.MyCoordinates.X+5, emulationTrolleyBuss.MyCoordinates.Y);

                Brush brush = (emulationTrolleyBuss.NeedDriverHelp || emulationTrolleyBuss.NeedEmergencyHelp)?new SolidBrush(Color.Red):new SolidBrush(Color.DarkGreen);

                g.FillPolygon(brush, points);
            }
            
            var emergencyPoints = new Point[4];

            emergencyPoints[0] = new Point(_emulation.EmergencyService.TargetCoordinates.X, _emulation.EmergencyService.TargetCoordinates.Y);
            emergencyPoints[1] = new Point(_emulation.EmergencyService.TargetCoordinates.X, _emulation.EmergencyService.TargetCoordinates.Y+5);
            emergencyPoints[2] = new Point(_emulation.EmergencyService.TargetCoordinates.X+5, _emulation.EmergencyService.TargetCoordinates.Y+5);
            emergencyPoints[3] = new Point(_emulation.EmergencyService.TargetCoordinates.X+5, _emulation.EmergencyService.TargetCoordinates.Y);

            Brush emergencyBrush = new SolidBrush(Color.Blue);

            g.FillPolygon(emergencyBrush, emergencyPoints);
            
        }

        private void PanelRepaint()
        {
            while (true)
            {
                Thread.Sleep(50);
                panel1.Invalidate();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (_repaintThread == null)
            {
                int Step = 2;
                TrolleyBuss tb1 = new TrolleyBuss(10, 1, 
                    new Coordinates(4,4,Step),
                    new Route(new List<Coordinates>(){new Coordinates(4, 4, Step),
                        new Coordinates(panel1.Width-4, 4, Step),
                        new Coordinates(panel1.Width-4, panel1.Height-4, Step),
                        new Coordinates(4, panel1.Height -4, Step)
                    }));
                Driver driver1 = new Driver();
                tb1.Driver = driver1;
                driver1.TrolleyBuss = tb1;
                EmergencyService emergencyService = new EmergencyService(new Coordinates(panel1.Width/2,panel1.Height/2, Step), new Coordinates(panel1.Width/2,panel1.Height/2, Step));
                _emulation = new Emulation(emergencyService, new List<TrolleyBuss>(){tb1});
                _emulation.Start();
                _repaintThread = new Thread(PanelRepaint);
                _repaintThread.Start();
                startButton.Text = @"Stop";
            }
            else
            {
                _emulation.Stop();
                _repaintThread.Abort();
                _repaintThread = null;
                startButton.Text = @"Start";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _emulation?.Stop();
            _repaintThread?.Abort();
        }
    }
}