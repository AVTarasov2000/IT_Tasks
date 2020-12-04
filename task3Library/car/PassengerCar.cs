namespace task3
{
    public abstract class PassengerCar
    {
        public int Number { get; set; }
        public int PeopleCount { get; }
        public int BaggageCount { get; }
        public int Prestige { get; set; }


        public PassengerCar(int number, int baggageCount, int peopleCount) 
        {
            Prestige = 2;
            BaggageCount = baggageCount;
            PeopleCount = peopleCount;
            Number = number;
        }
        
        public override string ToString()
        {
            return "-{number: " + Number+"| prestige: "+Prestige+"}";
        }
        
    }
}