using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //integer data types are used with numbers  -2147483648 to 2147483647
            //long data types are used with numbers -9223372036854775808 to 9223372036854775807
            //shart data types are used with numbers -32768 to 32767
            //byte data types are used with numbers 0 to 255
            int number1 = 2147483647;//4byte
            long number2 = 9223372036854775807;//8byte
            short number3 = -32768;//2byte
            byte number4 = 255;//1 byte
            bool condition = true;//or false 
            char character = 'M';//1 byte
            double number5 = 10.5;//8 byte
            decimal number6 = 17.5m;//16 byte
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("number2 is {0}", number2);
            Console.WriteLine("number3 is {0}", number3);
            Console.WriteLine("number4 is {0}", number4);
            Console.WriteLine("character is :{0}", character);
            Console.WriteLine("number5 is :{0}", number5);
            Console.WriteLine("number6 is:{0}", number6);
            Console.WriteLine(Days.Thursday);
            Console.WriteLine((int)Days.Thursday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday = 7, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
