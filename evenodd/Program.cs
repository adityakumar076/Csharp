namespace evenodd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number : ");
            int n = Int16.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {

                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
