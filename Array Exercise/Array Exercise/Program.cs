using System;

namespace Array_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 10, 20, 25, 30, 15, 40 };
            Console.WriteLine("Array is writing");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("5 değerinin indisi:"+Array.IndexOf(list,5));
            list.SetValue(10, 5);

            Console.WriteLine("Indis 3 deg;"+list.GetValue(3));
            Console.WriteLine("Array is writing");

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("15 değerinin indisi:" + Array.IndexOf(list, 15));




        }
    }
}
