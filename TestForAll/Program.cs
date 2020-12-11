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
            int step = 1;
            TrolleyBuss tb1 = new TrolleyBuss(10, 3, 
                new Coordinates(1,1, step),
                new Route(new List<Coordinates>(){new Coordinates(20, 50, step), new Coordinates(2, 2, step)}));
            Driver driver1 = new Driver();
            tb1.Driver = driver1;
            driver1.TrolleyBuss = tb1;
            EmergencyServiceImpl emergencyServiceImpl = new EmergencyServiceImpl(new Coordinates(1,1, step), new Coordinates(1,1, step));
            Emulation emulation = new Emulation(emergencyServiceImpl, new List<TrolleyBuss>(){tb1});
            emulation.Start();
        }
    }
}