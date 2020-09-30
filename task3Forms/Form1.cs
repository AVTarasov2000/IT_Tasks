using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task3;

namespace task3Forms
{
    public partial class Form1 : Form
    {
        private Train Train;
        public Form1()
        {
            Train = new Train();
            InitializeComponent();
        }

        private void addPassengerCarButton_Click(object sender, EventArgs e)
        {
            Train.AddNewPassengerCar((int) numericMaxWeight.Value, (int) baggageCount.Value, (int) numericPeopleCount.Value);
            setTrain();
        }

        private void addBaggageCarButton_Click(object sender, EventArgs e)
        {
            Train.AddNewBaggageCar((int) numericMaxWeight.Value, (int) baggageCount.Value);
            setTrain();
        }

        private void addPremiumCassButton_Click(object sender, EventArgs e)
        {
            Train.AddNewPremiumCar((int) numericMaxWeight.Value, (int) baggageCount.Value, (int) numericPeopleCount.Value);
            setTrain();
        }

        private void addFirstClassButton_Click(object sender, EventArgs e)
        {
            Train.AddNewFirstClassCar((int) numericMaxWeight.Value, (int) baggageCount.Value, (int) numericPeopleCount.Value);
            setTrain();
        }

        private void addSecondClassButton_Click(object sender, EventArgs e)
        {
            Train.AddNewSecondClassCar((int) numericMaxWeight.Value, (int) baggageCount.Value, (int) numericPeopleCount.Value);
            setTrain();
        }

        private void sort_Click(object sender, EventArgs e)
        {
            String res = "";
            foreach (Car car in Train.GetSortedByPrestige())
            {
                res += car.ToString();
            }
            train.Text = res;
        }

        private void getByPeopleBetween_Click(object sender, EventArgs e)
        {
            String res = "";
            foreach (Car car in Train.GetCarsWithPeopleCountBetween((int) numericMax.Value, (int) numericMin.Value))
            {
                res += car.ToString();
            }

            train.Text = res;
        }

        private void setTrain()
        {
            String res = "";
            foreach (Car car in Train.GetSortedByNumber())
            {
                res += car.ToString();
            }

            train.Text = res;
        }
    }
}