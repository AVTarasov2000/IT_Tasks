﻿using System.Threading;

namespace task8Library
{
    public class Driver
    {
        public TrolleyBuss TrolleyBuss { get; set; }
        public event Emulation.MethodContainer OnActionWriting;

        public void Start()
        {
            while (true)
            {
                if (TrolleyBuss.NeedDriverHelp)
                {
                    FixBuss(TrolleyBuss);
                }
                Thread.Sleep(500);
            }
        }

        public void FixBuss(TrolleyBuss trolleyBuss)
        {
            trolleyBuss.NeedDriverHelp = false;
            OnActionWritingFunction("the buss fixed by driver");
        }
        public virtual void OnActionWritingFunction(string message)
        {
            OnActionWriting?.Invoke(message);
        }
    }
}