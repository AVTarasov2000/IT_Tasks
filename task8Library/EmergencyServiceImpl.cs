using System.Collections.Generic;
using System.Threading;

namespace task8Library
{
    public class EmergencyServiceImpl: IEmergencyService
    {
        public EmergencyServiceImpl(Coordinates targetCoordinates, Coordinates baseCoordinates)
        {
            TargetCoordinates = targetCoordinates;
            BaseCoordinates = baseCoordinates;
        }

        public event Emulation.MethodContainer OnActionWriting;
        public List<TrolleyBuss> NeedHelp { get; } = new List<TrolleyBuss>();

        public Coordinates TargetCoordinates { get; set; }
        public Coordinates BaseCoordinates { get; set; }

        public EmergencyServiceImpl()
        {
        }

        public virtual void Start()
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
                    while (!TargetCoordinates.IsOn(tb.MyCoordinates))
                    {
                        GoTo(tb.MyCoordinates);
                    }
                    FixBuss(tb);
                }
            }
        }

        public bool IsWaiting()
        {
            return TargetCoordinates.IsOn(BaseCoordinates);
        }

        public virtual TrolleyBuss NextToFix()
        {
            if (NeedHelp.Count > 0)
            {
                return NeedHelp[0];
            }
            else
            {
                return null;
            }
        }
        
        public virtual void GoTo(Coordinates coordinates)
        {
            Thread.Sleep(100);
            if (!TargetCoordinates.IsOn(coordinates))
            {
                TargetCoordinates.MoveTo(coordinates);
            }
            
        }

        public virtual void NeedToBeFixed(TrolleyBuss tb)
        {
            NeedHelp.Add(tb);
        }
        public void FixBuss(TrolleyBuss trolleyBuss)
        {
            Thread.Sleep(2000);
            trolleyBuss.NeedEmergencyHelp = false;
            OnActionWritingFunction("the buss fixed by service");
            NeedHelp.Remove(trolleyBuss);

        }
        private void OnActionWritingFunction(string message)
        {
            OnActionWriting?.Invoke(message);
        }
    }
}