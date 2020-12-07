using System;

namespace task8Library
{
    public class TrolleyBuss
    {
        public delegate void MethodContainer(string message);
        public event MethodContainer OnActionWriting;
        public delegate void NeedHelp();
        public event NeedHelp OnSimpleBrake;
        public event NeedHelp OnComplexBrake;
        

        public Driver Driver { get; set; }
        public bool NeedEmergencyHelp { get; set; }
        public bool NeedDriverHelp { get; set; }
        private int SimpleBrakeChance { get; set; }
        private int ComplexBrakeChance { get; set; }

        public TrolleyBuss(int simpleBrakeChance, int complexBrakeChance)
        {
            if (simpleBrakeChance > 100 || complexBrakeChance > 100 ||
                simpleBrakeChance < 0 || complexBrakeChance < 0)
                throw new ArgumentOutOfRangeException();
            SimpleBrakeChance = simpleBrakeChance;
            ComplexBrakeChance = complexBrakeChance;
        }

        public void Move()
        {
            if (NeedDriverHelp || NeedEmergencyHelp)
            {
                OnActionWritingFunction("The buss cant move it's broken");
                return;
            }

            if (IsSimplyBroken())
            {
                OnActionWritingFunction("the buss has broken and needs Drivers help");
                OnSimpleBrake.Invoke();
                return;
            }

            if (IsComplexBroken())
            {
                OnActionWritingFunction("the buss has broken and needs emergency service");
                OnComplexBrake.Invoke();
                return;
            }

            OnActionWritingFunction("Buss moved");
        }
        
        private bool IsSimplyBroken()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 100);
            if (x < SimpleBrakeChance)
            {
                NeedDriverHelp = true;
                return true;
            }
            return false;
        }
        
        private bool IsComplexBroken()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 100);
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