using System;
using System.Collections.Generic;
using System.Linq;

namespace task3
{
    public class Train
    {
        List<Car> _cars = new List<Car>();
        private int lastCarNumber = 0;

        public Train()
        {
        }

        public void AddCar(Car car)
        {
            car.Number = lastCarNumber++;
            _cars.Add(car);
        }
        
        public void AddNewPassengerCar(int maxWeight, int baggageCount, int passengerCount)
        {
            _cars.Add(new PassengerCar(lastCarNumber++,maxWeight,baggageCount,passengerCount));
        }
        
        public void AddNewSecondClassCar(int maxWeight, int baggageCount, int passengerCount)
        {
            _cars.Add(new SecondClassCar(lastCarNumber++,maxWeight,baggageCount,passengerCount));
        }
        public void AddNewFirstClassCar(int maxWeight, int baggageCount, int passengerCount)
        {
            _cars.Add(new FirstClassCar(lastCarNumber++,maxWeight,baggageCount,passengerCount));
        }
        public void AddNewPremiumCar(int maxWeight, int baggageCount, int passengerCount)
        {
            _cars.Add(new PremiumClassCar(lastCarNumber++,maxWeight,baggageCount,passengerCount));
        }

        public void AddNewBaggageCar(int maxWeight, int baggageCount)
        {
            _cars.Add(new BaggageCar(lastCarNumber++,maxWeight,baggageCount));

        }

        public int GetPassengersCount()
        {
            int res = 0;
            foreach (Car car in _cars)
            {
                if(car is PassengerCar)
                    res += ((PassengerCar)car).PeopleCount;
            }
            return res;
        }

        public int GetBaggageCount()
        {
            int res = 0;
            foreach (Car car in _cars)
            {
                if(car is BaggageCar)
                    res += ((BaggageCar)car).BaggageCount;
            }

            return res;
        }

        public List<Car> GetCarsWithPeopleCountBetween (int max, int min)
        {
            List<Car> res = _cars.FindAll(car => (car is PassengerCar && ((PassengerCar) car).PeopleCount > min && ((PassengerCar) car).PeopleCount < max)).ToList();
            return res;
        }

        public List<Car> GetSortedByPrestige()
        {
            return _cars.OrderBy(car => car.Prestige).ToList();
        }
        
        public List<Car> GetSortedByNumber()
        {
            return _cars.OrderBy(car => car.Number).ToList();
        }
        
        
    }
}