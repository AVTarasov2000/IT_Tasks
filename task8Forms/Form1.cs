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
        private Image _busImage;
        private Image _brokenBuss;
        private Image _driverImage;
        private Image _emergencyOnBase;
        private Image _emergencyMooving;
        public Form1()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint;
            System.IO.FileStream fs = new System.IO.FileStream(@"kisspng-school-bus.jpg", System.IO.FileMode.Open);
            _busImage = Image.FromStream(fs);
            fs = new System.IO.FileStream(@"broken-bus.jpg", System.IO.FileMode.Open);
            _brokenBuss = Image.FromStream(fs);
            fs = new System.IO.FileStream(@"driver.jpg", System.IO.FileMode.Open);
            _driverImage = Image.FromStream(fs);
            fs = new System.IO.FileStream(@"emergencyServise.png", System.IO.FileMode.Open);
            _emergencyOnBase = Image.FromStream(fs);
            fs = new System.IO.FileStream(@"emergencyMooving.png", System.IO.FileMode.Open);
            _emergencyMooving = Image.FromStream(fs);
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
            

            if (_emulation.EmergencyService.IsWaiting())
            {
                g.DrawImage(_emergencyOnBase, _emulation.EmergencyService.TargetCoordinates.X, _emulation.EmergencyService.TargetCoordinates.Y, 50,50);
            }
            else
            {
                g.DrawImage(_emergencyMooving, _emulation.EmergencyService.TargetCoordinates.X, _emulation.EmergencyService.TargetCoordinates.Y, 80,50);
            }

            
            foreach (var emulationTrolleyBuss in _emulation.TrolleyBusses)
            {
                Point[] points = new Point[4];

                points[0] = new Point(emulationTrolleyBuss.MyCoordinates.X, emulationTrolleyBuss.MyCoordinates.Y);
                points[1] = new Point(emulationTrolleyBuss.MyCoordinates.X, emulationTrolleyBuss.MyCoordinates.Y+5);
                points[2] = new Point(emulationTrolleyBuss.MyCoordinates.X+5, emulationTrolleyBuss.MyCoordinates.Y+5);
                points[3] = new Point(emulationTrolleyBuss.MyCoordinates.X+5, emulationTrolleyBuss.MyCoordinates.Y);
                
                if (emulationTrolleyBuss.NeedEmergencyHelp)
                {
                    g.DrawImage(_brokenBuss, emulationTrolleyBuss.MyCoordinates.X, emulationTrolleyBuss.MyCoordinates.Y, 100,30);
                    
                }
                else
                {
                    g.DrawImage(_busImage, emulationTrolleyBuss.MyCoordinates.X, emulationTrolleyBuss.MyCoordinates.Y, 100,30);
                    if (emulationTrolleyBuss.NeedDriverHelp)
                    {
                        g.DrawImage(_driverImage, emulationTrolleyBuss.MyCoordinates.X+70, emulationTrolleyBuss.MyCoordinates.Y, 30,60);
                    }
                }
            }
            
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
                TrolleyBuss tb1 = new TrolleyBuss((int) simpleBreakNumeric.Value, (int) complexBreakNumeric.Value,
                    new Coordinates(4,4,Step),
                    new Route(new List<Coordinates>(){
                        new Coordinates(4, 4, Step),
                        new Coordinates(panel1.Width-110, 4, Step),
                        // new Coordinates(panel1.Width-4, panel1.Height-4, Step),
                        // new Coordinates(4, panel1.Height -4, Step)
                    }));
                Driver driver1 = new Driver();
                tb1.Driver = driver1;
                driver1.TrolleyBuss = tb1;

                TrolleyBuss tb2 = new TrolleyBuss((int) simpleBreakNumeric.Value, (int) complexBreakNumeric.Value,
                    new Coordinates(4, 100, Step),
                    new Route(new List<Coordinates>(){
                        // new Coordinates(4, 4, Step),
                        // new Coordinates(panel1.Width-4, 4, Step),
                        new Coordinates(4, 100, Step),
                        new Coordinates(panel1.Width-110, 100, Step)
                    }));
                Driver driver2 = new Driver();
                tb2.Driver = driver2;
                driver2.TrolleyBuss = tb2;
                
                EmergencyService emergencyService = new EmergencyService(new Coordinates(panel1.Width/2,panel1.Height/2, Step), new Coordinates(panel1.Width/2,panel1.Height/2, Step));
                _emulation = new Emulation(emergencyService, new List<TrolleyBuss>(){tb1, tb2});
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

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}