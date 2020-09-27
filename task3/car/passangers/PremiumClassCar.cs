namespace task3
{
    public class PremiumClassCar:PassengerCar
    {
        public PremiumClassCar(int number, int maxWeight, int baggageCount, int peopleCount) : base(number, maxWeight, baggageCount, peopleCount)
        {
            prestige = 4;
        }
    }
}