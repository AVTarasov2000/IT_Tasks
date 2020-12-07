namespace task8Library
{
    public class Driver
    {
        public TrolleyBuss TrolleyBuss { get; set; }
        public void FixBuss(TrolleyBuss trolleyBuss)
        {
            trolleyBuss.NeedDriverHelp = false;
        }
    }
}