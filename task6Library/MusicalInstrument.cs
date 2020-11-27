namespace task6
{
    public interface MusicalInstrument
    {
        string Name
        {
            get;
            set;
        }

        void Play();

        void Tune();
    }
}