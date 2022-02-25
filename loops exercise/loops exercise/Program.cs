using System;

namespace loops_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, factor;
            bool isprime;
            for ( num = 2; num < 20; num++)
            {
                isprime = true;
                factor = 0;
                for ( i = 2; i < num/2; i++)
                {
                    if ((num % i) == 0)
                    {
                        isprime = false;
                        factor = i;
                    }
                }
                if (isprime)
                    Console.WriteLine(num + "is prime.");
                else
                    Console.WriteLine(num + "is not prime.");

            }
        }
    }
}
