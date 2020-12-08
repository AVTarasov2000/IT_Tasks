using System;
using System.Threading;
using task8Library;

namespace TestForAll
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            EmergencyService emergencyService = new EmergencyService(new Coordinates(1,1), new Coordinates(1,1));
            Emulation emulation = new Emulation(emergencyService);
            emulation.Start();
        }
    }
}