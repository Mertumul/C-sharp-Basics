using System;

namespace Switch_case_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x < 6; x++)
            {
                switch (x)
                {
                    case 2:
                        Console.WriteLine("x is {0}--in case2", x); break;
                    case 5:
                        Console.WriteLine("x is {0}--in case5", x); break;
                    default:
                        Console.WriteLine("x is {0}--in default case", x); break;


                }
            }

        }
    }
}
