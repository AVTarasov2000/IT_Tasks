using System;
using System.Reflection;

namespace task6
{
    public class ElectricGuitar: Guitar
    {
        public string Company { get; set; }
        public bool Bass { get; set; }
        public void ConnectToCombic()
        {
            Console.WriteLine("instrument {0} is connected", Name);
        }

        public void DisconectFromCombic()
        {
            Console.WriteLine("instrument {0} is disconnected", Name);
        }
    }
}