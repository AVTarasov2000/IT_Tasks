namespace task3
{
    public class SecondClassCar:PassengerCar
    {
        public SecondClassCar(int number, int baggageCount, int peopleCount) : base(number, baggageCount, peopleCount)
        {
            Prestige = 2;
        }
    }
}