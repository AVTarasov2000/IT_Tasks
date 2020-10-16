namespace task4
{
    public class Hous
    {
        

        public int NumberOfHous
        {
            get;
            set;
        }

        public int CountOfFlats
        {
            get;
            set;
        }

        public int BildYear
        {
            get;
            set;
        }

        public Hous()
        {
        }

        public Hous(int numberOfHous, int countOfFlats, int bildYear)
        {
            this.NumberOfHous = numberOfHous;
            this.CountOfFlats = countOfFlats;
            this.BildYear = bildYear;
        }

        public virtual int Q(int nowYear)
        {
            return CountOfFlats + 2 * (nowYear - BildYear);
        }

        public int GetQ(int nowYear)
        {
            return Q(nowYear);
        }
    }
}