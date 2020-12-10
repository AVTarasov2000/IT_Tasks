using System.Collections.Generic;
using System.Threading;

namespace task8Library
{
    public class EmergencyService
    {
        public EmergencyService(Coordinates targetCoordinates, Coordinates baseCoordinates)
        {
            TargetCoordinates = targetCoordinates;
            BaseCoordinates = baseCoordinates;
        }

        public event Emulation.MethodContainer OnActionWriting;
        private List<TrolleyBuss> NeedHelp { get; } = new List<TrolleyBuss>();

        public Coordinates TargetCoordinates { get; set; }
        public Coordinates BaseCoordinates { get; set; }
        

        public void Start()
        {
            while (true)
            {
                if (NeedHelp.Count == 0)
                {
                    GoTo(BaseCoordinates);
                }
                else
                {
                    TrolleyBuss tb = NeedHelp[0];
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
        
        public void GoTo(Coordinates coordinates)
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

        public void NeedToBeFixed(TrolleyBuss tb)
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
        public virtual void OnActionWritingFunction(string message)
        {
            OnActionWriting?.Invoke(message);
        }
    }
}