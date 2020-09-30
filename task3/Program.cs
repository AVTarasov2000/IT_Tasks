using System;

namespace task3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Train train = new Train();
            BaggageCar car = new BaggageCar(1,2000, 0);
            car.addBaggage(100);
            train.AddNewPassengerCar(1000,20, 60);
            train.AddNewPassengerCar(1000,30, 40);
            train.AddNewPassengerCar(1000,60, 30);
            train.AddNewPassengerCar(1000,60, 50);
            train.AddNewPassengerCar(1000,60, 60);
            train.AddNewPassengerCar(1000,60, 60);
            train.AddCar(car);
            Console.WriteLine(train.GetBaggageCount());
            Console.WriteLine(train.GetPassengersCount());
            foreach (Car car1 in train.GetCarsWithPeopleCountBetween(65, 55))
            {
                Console.WriteLine(car1.ToString());
            }
        }
    }
}