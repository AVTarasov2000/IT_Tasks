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
                    Thread.Sleep(500);
                }
                else
                {
                    TrolleyBuss tb = NeedHelp[0];
                    GoTo(tb.MyCoordinates);
                    FixBuss(tb);
                    GoTo(BaseCoordinates);
                }
            }
        }
        
        public void GoTo(Coordinates coordinates)
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

        public void NeedToBeFixed(TrolleyBuss tb)
        {
            NeedHelp.Add(tb);
        }
        public void FixBuss(TrolleyBuss trolleyBuss)
        {
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