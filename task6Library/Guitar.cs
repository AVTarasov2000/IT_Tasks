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
        
        
        
        public virtual void Play()
        {
            onConsoleWrite(String.Format("playing instrument {0}", Name));
            Console.WriteLine("playing instrument {0}", Name);
        }

        public virtual void Tune()
        {
            onConsoleWrite(String.Format("tuning instrument {0}", Name));
            Console.WriteLine("tuning instrument {0}", Name);
        }

        public virtual void StringBroke(int stringNumber)
        {
            onConsoleWrite(String.Format("{0} string broken", stringNumber));
            Console.WriteLine("{0} string broken",  stringNumber);
        }

        public virtual void SoundChord(string chord)
        {
            onConsoleWrite(String.Format("{0} {0} {0} {0} {0}", chord));
            Console.WriteLine("{0} {0} {0} {0} {0}",  chord);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}