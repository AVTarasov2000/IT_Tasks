namespace task3
{
    public class FirstClassCar:PassengerCar
    {
        public FirstClassCar(int number, int baggageCount, int peopleCount) : base(number, baggageCount, peopleCount)
        {
            Prestige = 3;
        }

        public FirstClassCar()
        {
        }
    }
}