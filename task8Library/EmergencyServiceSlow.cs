using System.Threading;

namespace task8Library
{
    public class EmergencyServiceSlow: EmergencyServiceImpl
    {
        public EmergencyServiceSlow(Coordinates targetCoordinates, Coordinates baseCoordinates) : base(targetCoordinates, baseCoordinates)
        {
        }

        public EmergencyServiceSlow()
        {
        }

        public override void Start()
        {
            while (true)
            {
                if (base.NeedHelp.Count == 0)
                {
                    Thread.Sleep(500);
                }
                else
                {
                    TrolleyBuss tb = NeedHelp[0];
                    while (!TargetCoordinates.IsOn(tb.MyCoordinates));
                    GoTo(tb.MyCoordinates);
                    FixBuss(tb);
                    GoTo(BaseCoordinates);
                }
            }
        }

        public override void GoTo(Coordinates coordinates)
        {
            while (true)
            {
                Thread.Sleep(100);
                if (TargetCoordinates.IsOn(coordinates))
                {
                    return;
                }
                else
                {
                    TargetCoordinates.MoveTo(coordinates);
                }
            }
        }
    }
}