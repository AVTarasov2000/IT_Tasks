namespace task4
{
    public class Hous
    {
        private int numberOfHous;
        private int countOfFlats;
        private int bildYear;

        public int NumberOfHous
        {
            get => numberOfHous;
            set => numberOfHous = value;
        }

        public int CountOfFlats
        {
            get => countOfFlats;
            set => countOfFlats = value;
        }

        public int BildYear
        {
            get => bildYear;
            set => bildYear = value;
        }

        public Hous()
        {
        }

        public Hous(int numberOfHous, int countOfFlats, int bildYear)
        {
            this.numberOfHous = numberOfHous;
            this.countOfFlats = countOfFlats;
            this.bildYear = bildYear;
        }

        public int Q(int nowYear)
        {
            return countOfFlats + 2 * (nowYear - bildYear);
        }
    }
}