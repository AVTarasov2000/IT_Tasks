using System;
using System.Collections.Generic;
using System.Threading;

namespace task8Library
{
    public class Emulation
    {
        public List<TrolleyBuss> TrolleyBusses { get; set; } = new List<TrolleyBuss>();
        public void Start()
        {
            SetActors();
            int i = 0;
            while (i<100000)
            {
                foreach (var trolleyBuss in TrolleyBusses)
                {
                    trolleyBuss.Move();
                    Thread.Sleep(500);
                }

                i++;
            }
        }

        private void SetActors()
        {
            TrolleyBuss tb1 = new TrolleyBuss(10, 5);
            Driver driver1 = new Driver();
            tb1.Driver = driver1;
            driver1.TrolleyBuss = tb1;
            tb1.OnActionWriting += EchoFunc;
            TrolleyBusses.Add(tb1);
        }

        public void EchoFunc(string message)
        {
            Console.WriteLine(message);
        }
    }
}