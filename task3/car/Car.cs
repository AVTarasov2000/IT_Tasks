namespace task3
{
    public class Car
    {
        private int number;
        private int maxWeight;
        private protected int prestige = 0;

        public int Prestige => prestige;

        public Car(int number, int maxWeight)
        {
            this.number = number;
            this.maxWeight = maxWeight;
        }
        
        
        public int MaxWeight
        {
            get => maxWeight;
            set => maxWeight = value;
        }

        public int Number
        {
            get => number;
            set => number = value;
        }
        
    }
}