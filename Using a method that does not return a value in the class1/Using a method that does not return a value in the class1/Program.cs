using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_a_method_that_does_not_return_a_value_in_the_class1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            string job;

            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Surname:");
            surname = Console.ReadLine();
            Console.WriteLine("Enter Job:");
            job = Console.ReadLine();
            Contacs c1 = new Contacs();
            c1.contactslistandstatus("Mert","Umul","Computer Engineer");


        }
    }
}
