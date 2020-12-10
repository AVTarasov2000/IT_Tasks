using System;
using System.Collections.Generic;
using System.Threading;
using task8Library;

namespace TestForAll
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TrolleyBuss tb1 = new TrolleyBuss(10, 3, 
                new Coordinates(1,1),
                new Route(new List<Coordinates>(){new Coordinates(20, 50), new Coordinates(2, 2)}));
            Driver driver1 = new Driver();
            tb1.Driver = driver1;
            driver1.TrolleyBuss = tb1;
            EmergencyService emergencyService = new EmergencyService(new Coordinates(1,1), new Coordinates(1,1));
            Emulation emulation = new Emulation(emergencyService, new List<TrolleyBuss>(){tb1});
            emulation.Start();
        }
    }
}