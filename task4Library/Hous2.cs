namespace task4
{
    public class Hous2:Hous
    {
        
        public Hous2()
        {
        }

        public override int Q(int nowYear)
        {
            return 2 * base.Q(nowYear);
        }
        
    }
}