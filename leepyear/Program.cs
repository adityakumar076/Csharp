using System;

namespace leepyear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year:");
            int year = int.Parse(Console.ReadLine());

            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine(year + " is a Leap Year.");
            }
            else
            {
                Console.WriteLine(year + " is NOT a Leap Year.");
            }
        }
    }
}