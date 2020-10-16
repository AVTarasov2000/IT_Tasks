namespace task3
{
    public class PremiumClassCar:PassengerCar
    {
        public PremiumClassCar(int number, int baggageCount, int peopleCount) : base(number, baggageCount, peopleCount)
        {
            Prestige = 4;
        }
    }
}