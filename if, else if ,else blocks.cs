﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = 21;            
            if (number==10)
            {
                Console.WriteLine("number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20!!");
            }
            Console.ReadLine();
        }
    }
}