namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1, sum = 0;

            while (n < 10000)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    sum += n;
                }
                n++;
            }

            Console.WriteLine(sum);
        }
    }
}
