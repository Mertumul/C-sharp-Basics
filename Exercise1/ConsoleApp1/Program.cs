using System;

namespace ConsoleApp1
{
    class Program
    {

         public  static void addition(int n1,int n2)
        {
            int result = n1 + n2;
            Console.WriteLine("x+y:" + result);
        }
        public static  void subtraction(int n1, int n2)
        {
            int result = n1 - n2;
            Console.WriteLine("x-y:" + result);
        }
         public static  void multiplication(int n1, int n2)
        {
            int result = n1 * n2;
            Console.WriteLine("x*y:" + result);
        }
       public static void division(float n1, float n2)
        {
            float result = n1 / n2;
            Console.WriteLine("x/y:" + result);
        }
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Please enter the first number that u want:");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the second number that u want:");

            n2 = Convert.ToInt16(Console.ReadLine());
            addition(n1, n2);
            subtraction(n1, n2);
            multiplication(n1, n2);
            division(n1, n2);
            Console.ReadKey();


        }
    }
}
