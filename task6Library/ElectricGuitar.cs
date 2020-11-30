using System;
using System.Reflection;

namespace task6
{
    public class ElectricGuitar: Guitar
    {
        public string Company { get; set; }
        public bool Bass { get; set; }
        
        public event MethodContainer onConsoleWrite;
        
        public void ConnectToCombic()
        {
            onConsoleWrite(String.Format("instrument {0} is connected", Name));
            Console.WriteLine("instrument {0} is connected", Name);
        }

        public void DisconectFromCombic()
        {
            onConsoleWrite(String.Format("instrument {0} is disconnected", Name));
            Console.WriteLine("instrument {0} is disconnected", Name);
        }
    }
}