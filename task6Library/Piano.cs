namespace task6
{
    public class Piano: MusicalInstrument
    {
        public string PianingPiano()
        {
            return "piaing Piano";
        }

        public string Name { get; set; }
        public string Play()
        {
            return "playing Piano";
        }

        public string Tune()
        {
            return "tuning piano";
        }
    }
}