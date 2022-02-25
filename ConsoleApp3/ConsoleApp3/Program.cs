using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 12, 20, 22, 17, 22, 9, 3, 1, 2 };
            Single ort;
            int total = 0;
            int max, min;
            max = a[0];
            min = a[0];

            for (int i = 0; i < 10; i++)
            {
                if (max <= a[i])
                {
                    max = a[i];
                }
                if (min >= a[i])
                {
                    min = a[i];
                }
                Console.WriteLine("a[" + i + "]=" + a[i]);
                total += a[i];
            }
            ort = Convert.ToSingle(total) / 10;
            Console.WriteLine("Avarage:" + ort);
            Console.WriteLine("Min:" + min);
            Console.WriteLine("Max:" + max);


            Console.ReadKey();
        }
    }
}
