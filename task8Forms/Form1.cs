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
using task7Library;

namespace task8Forms
{
    public partial class Form1 : Form
    {
        private ClassLooker _classLooker;
        private Emulation _emulation;
        private Thread _repaintThread = null;
        private List<Type> _types = new List<Type>();
        private Type _choosedType;
        private Image _busImage;
        private Image _brokenBuss;
        private Image _driverImage;
        private Image _emergencyOnBase;
        private Image _emergencyMooving;
        public Form1()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint;
            
            _classLooker = new ClassLooker(@"C:\Users\Andrey\RiderProjects\IT_Tasks\task8Forms\bin\Debug\task8Library.dll");
            
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
            SetListOfClasses();
        }

        private void SetListOfClasses()
        {
            foreach (var allChildrenAndImpl in _classLooker.AllChildrenAndImpls(typeof(EmergencyService)))
            {
                AddRow(allChildrenAndImpl.Name);
                _types.Add(allChildrenAndImpl);
            }
        }

        private void AddRow(string className)
        {
            dataGridView1.Rows.Add(className);
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
            

            if (_emulation.EmergencyServiceImpl.IsWaiting())
            {
                g.DrawImage(_emergencyOnBase, _emulation.EmergencyServiceImpl.TargetCoordinates.X, _emulation.EmergencyServiceImpl.TargetCoordinates.Y, 50,50);
            }
            else
            {
                g.DrawImage(_emergencyMooving, _emulation.EmergencyServiceImpl.TargetCoordinates.X, _emulation.EmergencyServiceImpl.TargetCoordinates.Y, 80,50);
            }

            
            foreach (var emulationTrolleyBuss in _emulation.TrolleyBusses)
            {

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
                List<TrolleyBuss> allBusses = new List<TrolleyBuss>();
                int Step = 2;
                for (int i = 0; i < (int) countBussesNumeric.Value; i++)
                {
                    TrolleyBuss tb1 = new TrolleyBuss((int) simpleBreakNumeric.Value, (int) complexBreakNumeric.Value,
                        new Coordinates(4, 4 + 100 * i, Step),
                        new Route(new List<Coordinates>()
                        {
                            new Coordinates(4, 4 + 100 * i, Step),
                            new Coordinates(panel1.Width - 110, 4 + 100 * i, Step),
                        }));
                    Driver driver1 = new Driver();
                    tb1.Driver = driver1;
                    driver1.TrolleyBuss = tb1;
                    allBusses.Add(tb1);
                }

                Step *= 5;
                EmergencyService emergencyServiceImpl = (EmergencyService) Activator.CreateInstance(_choosedType);
                emergencyServiceImpl.BaseCoordinates = new Coordinates(panel1.Width / 2, panel1.Height / 2, Step);
                emergencyServiceImpl.TargetCoordinates = new Coordinates(panel1.Width / 2, panel1.Height / 2, Step);
                _emulation = new Emulation(emergencyServiceImpl, allBusses);
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
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["className"].Index)
            {
                _choosedType = _types[e.RowIndex];
            }
        }
    }
}