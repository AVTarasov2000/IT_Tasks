using System;
using System.Threading;

namespace task8Library
{
    public class TrolleyBuss
    {
        public event Emulation.MethodContainer OnActionWriting;
        public event Emulation.NeedHelp OnSimpleBrake;
        public event Emulation.NeedHelp OnComplexBrake;
        
        public Route Route { get; set; }
        public Coordinates MyCoordinates { get; set; }
        public Coordinates TargetCoordinates { get; set; }
        public Driver Driver { get; set; }
        public bool NeedEmergencyHelp { get; set; }
        public bool NeedDriverHelp { get; set; }
        private int SimpleBrakeChance { get; }
        private int ComplexBrakeChance { get; }
        private Random Random { get; } = new Random();

        public TrolleyBuss(int simpleBrakeChance, int complexBrakeChance, Coordinates myCoordinates, Route route)
        {
            if (simpleBrakeChance > 100 || complexBrakeChance > 100 ||
                simpleBrakeChance < 0 || complexBrakeChance < 0)
                throw new ArgumentOutOfRangeException();
            SimpleBrakeChance = simpleBrakeChance;
            ComplexBrakeChance = complexBrakeChance;
            MyCoordinates = myCoordinates;
            TargetCoordinates = myCoordinates;
            Route = route;
        }

        public void Start()
        {
            while (true)
            {
                if (!(NeedDriverHelp || NeedEmergencyHelp))
                {
                    Move();
                }
                Thread.Sleep(500);
            }
        }

        public void Move()
        {
            if (NeedDriverHelp || NeedEmergencyHelp)
            {
                OnActionWritingFunction("The buss cant move it's broken");
                return;
            }
            if (MyCoordinates.IsOn(TargetCoordinates))
            {
                OnActionWritingFunction("Buss stopped");
                TargetCoordinates = Route.Next();
            }
            else
            {
                if (IsSimplyBroken())
                {
                    OnActionWritingFunction("the buss has broken and needs Drivers help");
                    // OnSimpleBrake?.Invoke(this);
                    return;
                }

                if (IsComplexBroken())
                {
                    OnActionWritingFunction("the buss has broken and needs emergency service");
                    OnComplexBrake?.Invoke(this);
                    return;
                }
                
                OnActionWritingFunction("Buss moved");
                MyCoordinates.MoveTo(TargetCoordinates);
            }
        }
        
        private bool IsSimplyBroken()
        {
            int x = Random.Next(0, 100);
            if (x < SimpleBrakeChance)
            {
                NeedDriverHelp = true;
                return true;
            }
            return false;
        }
        
        private bool IsComplexBroken()
        {
            int x = Random.Next(0, 100);
            if (x < ComplexBrakeChance)
            {
                NeedEmergencyHelp = true;
                return true;
            }
            return false;
        }
        
        public virtual void OnActionWritingFunction(string message)
        {
            OnActionWriting?.Invoke(message);
        }
        
    }
}