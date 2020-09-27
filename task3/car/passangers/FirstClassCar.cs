namespace task3
{
    public class FirstClassCar:PassengerCar
    {
        public FirstClassCar(int number, int maxWeight, int baggageCount, int peopleCount) : base(number, maxWeight, baggageCount, peopleCount)
        {
            prestige = 3;
        }
    }
}