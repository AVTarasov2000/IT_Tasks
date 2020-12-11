namespace task8Library
{
    public class EmergencyServiceToNearest: EmergencyServiceImpl
    {
        public EmergencyServiceToNearest(Coordinates targetCoordinates, Coordinates baseCoordinates) : base(targetCoordinates, baseCoordinates)
        {
        }

        public EmergencyServiceToNearest()
        {
        }

        public override TrolleyBuss NextToFix()
        {
            TrolleyBuss tb = null;
            foreach (var trolleyBuss in NeedHelp)
            {
                if (tb == null)
                {
                    tb = trolleyBuss;
                }
                else
                {
                    if (TargetCoordinates.Distance(tb.MyCoordinates) >
                        TargetCoordinates.Distance(trolleyBuss.MyCoordinates))
                    {
                        tb = trolleyBuss;
                    }
                }
            }

            return tb;
        }
        
        public override void Start()
        {
            while (true)
            {
                if (NeedHelp.Count == 0)
                {
                    GoTo(BaseCoordinates);
                }
                else
                {
                    TrolleyBuss tb = NextToFix();
                    Coordinates coordinates = tb.MyCoordinates;
                    while (!TargetCoordinates.IsOn(coordinates))
                    {
                        coordinates = NextToFix().MyCoordinates;
                        GoTo(coordinates);
                    }
                    FixBuss(tb);
                }
            }
        }
    }
}