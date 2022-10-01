using System;

namespace Prime_and_Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("n is a prime number");
            }
            else
            {
                Console.WriteLine("n is a complex number");
            }
        }
    }
}
