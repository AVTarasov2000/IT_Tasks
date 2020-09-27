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

        public void AddPassengerCar(Car car)
        {
            _cars.Add(car);
        }
        
        public void AddNewPassengerCar(int maxWeight, int baggageCount, int passengerCount)
        {
            _cars.Add(new PassengerCar(lastCarNumber++,maxWeight,baggageCount,passengerCount));
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
                if(car is PassengerCar)
                    res += ((BaggageCar)car).BaggageCount;
            }

            return res;
        }

        public List<Car> GetCarsWithPeopleCountBetween (int max, int min)
        {
            List<Car> res = _cars.FindAll(car => (car is PassengerCar &&
                                  ((PassengerCar) car).PeopleCount>min &&
                                  ((PassengerCar) car).PeopleCount<max)).ToList();
            return res;
        }

        public void GetSortedByPrestige()
        {
            _cars.OrderBy(car => car.Prestige);
        }
        
        public void GetSortedByNumber()
        {
            _cars.OrderBy(car => car.Number);
        }
        
        
    }
}