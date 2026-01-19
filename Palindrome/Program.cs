namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Int16.Parse(Console.ReadLine());
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                Console.Write(false);
            }

            int reversed = 0;
            int original = x;

            while (x > 0)
            {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x /= 10;
            }

            Console.Write(reversed == original);

        

    }
    }
}
