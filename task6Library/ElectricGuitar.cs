using System;
using System.Reflection;

namespace task6
{
    public class ElectricGuitar: Guitar
    {
        public string Company { get; set; }
        public bool Bass { get; set; }
        

        
        public string ConnectToCombic()
        {
            ConsoleFunctionProcessing(String.Format("instrument {0} is connected", Name));
            Console.WriteLine("instrument {0} is connected", Name);
            return String.Format("instrument {0} is connected", Name);
        }

        public string DisconectFromCombic()
        {
            ConsoleFunctionProcessing(String.Format("instrument {0} is disconnected", Name));
            Console.WriteLine("instrument {0} is disconnected", Name);
            return String.Format("instrument {0} is connected", Name);
        }
    }
}