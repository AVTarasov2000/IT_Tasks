using System;

namespace task6
{
    public abstract class Guitar: MusicalInstrument
    {
        public string Name { get; set; }
        
        public string Type { get; set; }
        public string Formation { get; set; }
        public int StringsCount { get; set; }
        
        
        
        public void Play()
        {
            Console.WriteLine("playing instrument {0}", Name);
        }

        public void Tune()
        {
            Console.WriteLine("tuning instrument {0}", Name);
        }
        
        
        
    }
}