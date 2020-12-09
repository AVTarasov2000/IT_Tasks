using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace task8Library
{
    public class Emulation
    {

        public List<TrolleyBuss> TrolleyBusses { get; } = new List<TrolleyBuss>();
        public EmergencyService EmergencyService { get; }
        public Emulation(EmergencyService emergencyService, List<TrolleyBuss> trolleyBusses)
        {
            EmergencyService = emergencyService;
            EmergencyService.OnActionWriting += EchoFunc;
            TrolleyBusses = trolleyBusses;
        }
        public delegate void NeedHelp(TrolleyBuss tb);
        public delegate void MethodContainer(string message);
        public void Start()
        {
            // SetActors();
            foreach (var trolleyBuss in TrolleyBusses)
            {
                trolleyBuss.OnActionWriting += EchoFunc;
                trolleyBuss.Driver.OnActionWriting += EchoFunc;
                trolleyBuss.OnActionWriting += EchoFunc;
                trolleyBuss.OnSimpleBrake += trolleyBuss.Driver.FixBuss;
                trolleyBuss.OnComplexBrake += EmergencyService.NeedToBeFixed;
                
                Thread bussThread = new Thread(trolleyBuss.Start);
                bussThread.Start();
                Thread driverThread = new Thread(trolleyBuss.Driver.Start);
                driverThread.Start();
            }
            Thread thread = new Thread(EmergencyService.Start);
            thread.Start();
        }

        private void SetActors()
        {
            TrolleyBuss tb1 = new TrolleyBuss(10, 10, 
                new Coordinates(1,1),
                new Route(new List<Coordinates>(){new Coordinates(20, 50), new Coordinates(2, 2)}));
            Driver driver1 = new Driver();
            tb1.Driver = driver1;
            driver1.OnActionWriting += EchoFunc;
            driver1.TrolleyBuss = tb1;
            tb1.OnActionWriting += EchoFunc;
            tb1.OnSimpleBrake += driver1.FixBuss;
            tb1.OnComplexBrake += EmergencyService.NeedToBeFixed;
            TrolleyBusses.Add(tb1);
        }

        public void EchoFunc(string message)
        {
            Console.WriteLine(message);
        }
    }
}