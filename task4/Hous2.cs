namespace task4
{
    public class Hous2:Hous
    {
        private string area;

        public string Area
        {
            get => area;
            set => area = value;
        }

        public Hous2()
        {
        }

        public Hous2(int numberOfHous, int countOfFlats, int bildYear, string area) : base(numberOfHous, countOfFlats, bildYear)
        {
            this.area = area;
        }

        public int Q(int nowYear)
        {
            if (area.Equals("center"))
            {
                return 2 * base.Q(nowYear);
            }
            else
            {
                return base.Q(nowYear);
            }
        }
        
    }
}