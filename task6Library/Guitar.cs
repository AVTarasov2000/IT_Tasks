using System;

namespace task6
{
    public abstract class Guitar: MusicalInstrument
    {
        public delegate void MethodContainer(string message);
        public event MethodContainer onConsoleWrite;
        public string Name { get; set; }
        
        public string Type { get; set; }
        public string Formation { get; set; }
        public int StringsCount { get; set; }
        
        
        
        public virtual string Play()
        {
            ConsoleFunctionProcessing(String.Format("playing instrument {0}", Name));
            Console.WriteLine("playing instrument {0}", Name);
            return String.Format("playing instrument {0}", Name);

        }

        public virtual string Tune()
        {
            ConsoleFunctionProcessing(String.Format("tuning instrument {0}", Name));
            Console.WriteLine("tuning instrument {0}", Name);
            return String.Format("tuning instrument {0}", Name);
        }

        public virtual string StringBroke(int stringNumber)
        {
            ConsoleFunctionProcessing(String.Format("{0} string broken", stringNumber));
            Console.WriteLine("{0} string broken",  stringNumber);
            return String.Format("{0} string broken", stringNumber);
        }

        public virtual string SoundChord(string chord)
        {
            ConsoleFunctionProcessing(String.Format("{0} {0} {0} {0} {0}", chord));
            Console.WriteLine("{0} {0} {0} {0} {0}",  chord);
            return String.Format("{0} - {0} - {0} - {0} - {0}", chord);

        }

        public virtual void ConsoleFunctionProcessing(string message)
        {
            onConsoleWrite?.Invoke(message);
        }
        
        public override string ToString()
        {
            return Name;
        }
    }
}