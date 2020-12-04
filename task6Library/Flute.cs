namespace task6
{
    public class Flute: MusicalInstrument
    {
        public string Name { get; set; }
        public string Play()
        {
            return "playing Flute";
        }

        public string Tune()
        {
            return "tuning Flute";
        }
    }
}