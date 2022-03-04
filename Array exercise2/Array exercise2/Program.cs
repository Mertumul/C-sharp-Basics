using System;

namespace Array_exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] agac = new int[3][];
            agac[0] = new int[3];
            agac[1] = new int[5];
            agac[2] = new int[2];
            int i ,j;
            for ( i = 0; i < 3; i++)
            {
                for ( j = 0; j < agac[i].Length; j++)
                {
                    Console.WriteLine("agac[" + i + "][" + j + "]=");
                    string x = Console.ReadLine();
                    agac[i][j] = System.Convert.ToInt32(x);
                }

            }
            Console.ReadKey();


        }
    }
}
