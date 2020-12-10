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
        
        private List<Thread> _threads = new List<Thread>();
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
                _threads.Add(bussThread);
                _threads.Add(driverThread);
            };
            Thread thread = new Thread(EmergencyService.Start);
            thread.Start();
            _threads.Add(thread);
        }
        

        public void EchoFunc(string message)
        {
            Console.WriteLine(message);
        }

        public void Stop()
        {
            foreach (var thread in _threads)
            {
                thread.Abort();
            }
        }
    }
}