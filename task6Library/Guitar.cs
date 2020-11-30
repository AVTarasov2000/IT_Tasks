using System;

namespace task6
{
    public abstract class Guitar: MusicalInstrument
    {
        public string Name { get; set; }
        
        public string Type { get; set; }
        public string Formation { get; set; }
        public int StringsCount { get; set; }
        
        
        
        public virtual void Play()
        {
            Console.WriteLine("playing instrument {0}", Name);
        }

        public virtual void Tune()
        {
            Console.WriteLine("tuning instrument {0}", Name);
        }

        public virtual void StringBroke(int stringNumber)
        {
            Console.WriteLine("{0} string broken",  stringNumber);
        }

        public virtual void SoundChord(string chord)
        {
            Console.WriteLine("{0} {0} {0} {0} {0}",  chord);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}