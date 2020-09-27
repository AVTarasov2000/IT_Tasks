namespace task3
{
    public class PassengerCar: BaggageCar
    {
        private protected int peopleCount;

      
        public PassengerCar(int number, int maxWeight, int baggageCount, int peopleCount) : base(number, maxWeight, baggageCount)
        {
            this.peopleCount = peopleCount;
        }

        public void addPeople(int countOfPeople)
        {
            peopleCount += countOfPeople;
        }
        public int PeopleCount
        {
            get => peopleCount;
            set => peopleCount = value;
        }

    }
}