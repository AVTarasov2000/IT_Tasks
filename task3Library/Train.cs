using System;
using System.Collections.Generic;
using System.Linq;


namespace task3
{
    public class Train
    {
        List<PassengerCar> _cars = new List<PassengerCar>();
        private int lastCarNumber = 0;

        public Train()
        {
        }

        public void AddCar(PassengerCar car)
        {
            car.Number = lastCarNumber++;
            _cars.Add(car);
        }
        
        public void AddNewSecondClassCar( int baggageCount, int passengerCount)
        {
            _cars.Add(new SecondClassCar(lastCarNumber++,baggageCount,passengerCount));
        }
        public void AddNewFirstClassCar( int baggageCount, int passengerCount)
        {
            _cars.Add(new FirstClassCar(lastCarNumber++,baggageCount,passengerCount));
        }
        public void AddNewPremiumCar(int baggageCount, int passengerCount)
        {
            _cars.Add(new PremiumClassCar(lastCarNumber++,baggageCount,passengerCount));
        }
        
        public int GetPassengersCount()
        {
            int res = 0;
            foreach (PassengerCar car in _cars)
            {
                    res += car.PeopleCount;
            }
            return res;
        }

        public int GetBaggageCount()
        {
            int res = 0;
            foreach (PassengerCar car in _cars)
            {
                res += car.BaggageCount;
            }
            return res;
        }

        public List<PassengerCar> GetCarsWithPeopleCountBetween (int max, int min)
        {
            List<PassengerCar> res = _cars.FindAll(car => car is PassengerCar && car.PeopleCount > min &&  car.PeopleCount < max).ToList();
            return res;
        }

        public List<PassengerCar> GetSortedByPrestige()
        {
            return _cars.OrderBy(car => car.Prestige).ToList();
        }
        
        public List<PassengerCar> GetSortedByNumber()
        {
            return _cars.OrderBy(car => car.Number).ToList();
        }
        
        
    }
}