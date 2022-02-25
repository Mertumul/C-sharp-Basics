using System;

namespace Multidimensial_aaray_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matris = new int[4, 4];
            int i, j;

            for ( i = 0; i < 4; i++)
            {
                for (
                    j = 0; j < 4; j++)
                {
                    Console.WriteLine("Matris[" + i + " " + j + "]=");
                    string x = Console.ReadLine();
                    matris[i, j] = System.Convert.ToInt16(x);
                }
            }
        }
    }
}
