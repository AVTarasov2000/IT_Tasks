using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace task8Library
{
    public class Emulation
    {

        public List<TrolleyBuss> TrolleyBusses { get; } = new List<TrolleyBuss>();
        public IEmergencyService EmergencyServiceImpl { get; }
        
        private List<Thread> _threads = new List<Thread>();
        private Random Random;
        public Emulation(IEmergencyService emergencyServiceImpl, List<TrolleyBuss> trolleyBusses)
        {
            Random = new Random();
            EmergencyServiceImpl = emergencyServiceImpl;
            // EmergencyServiceImpl.OnActionWriting += EchoFunc;
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
                trolleyBuss.OnComplexBrake += EmergencyServiceImpl.NeedToBeFixed;
                trolleyBuss.Random = Random;
                Thread bussThread = new Thread(trolleyBuss.Start);
                bussThread.Start();
                Thread driverThread = new Thread(trolleyBuss.Driver.Start);
                driverThread.Start();
                _threads.Add(bussThread);
                _threads.Add(driverThread);
            };
            Thread thread = new Thread(EmergencyServiceImpl.Start);
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