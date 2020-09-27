using System;

namespace task4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Hous hous = new Hous();
            Hous2 hous2 = new Hous2();
            Console.WriteLine("wright int numberOfHous");
            hous.NumberOfHous = Int32.Parse(Console.ReadLine());
            Console.WriteLine("wright int countOfFlats");
            hous.CountOfFlats = Int32.Parse(Console.ReadLine());
            Console.WriteLine("wright int bildYear");
            hous.BildYear = Int32.Parse(Console.ReadLine());
            Console.WriteLine("wright int now Year");
            Console.WriteLine(hous.Q(Int32.Parse(Console.ReadLine())));
            
            Console.WriteLine("wright int numberOfHous");
            hous2.NumberOfHous = Int32.Parse(Console.ReadLine());
            Console.WriteLine("wright int countOfFlats");
            hous2.CountOfFlats = Int32.Parse(Console.ReadLine());
            Console.WriteLine("wright int bildYear");
            hous2.BildYear=Int32.Parse(Console.ReadLine());
            Console.WriteLine("wright int now Year");
            Console.WriteLine(hous.Q(Int32.Parse(Console.ReadLine())));
        }
    }
}