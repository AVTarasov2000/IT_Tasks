namespace task3
{
    public class SecondClassCar:PassengerCar
    {
        public SecondClassCar(int number, int maxWeight, int baggageCount, int peopleCount) : base(number, maxWeight, baggageCount, peopleCount)
        {
            prestige = 2;
        }
    }
}