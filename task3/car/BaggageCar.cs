namespace task3
{
    public class BaggageCar: Car
    {
        private int baggageCount;

        public int BaggageCount
        {
            get => baggageCount;
            set => baggageCount = value;
        }

        public void addBaggage(int baggageCount)
        {
            this.baggageCount += baggageCount;
        }
        
        public BaggageCar(int number, int maxWeight, int baggageCount) : base(number, maxWeight)
        {
            prestige = 1;
            this.baggageCount = baggageCount;
        }
    }
}