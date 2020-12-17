namespace task6
{
    public interface MusicalInstrument
    {
        string Name { get; set; }

        string Play();

        string Tune();
    }
}