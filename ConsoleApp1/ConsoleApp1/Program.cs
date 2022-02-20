using System;

namespace ConsoleApp1
{

    class Program
    {
      


        static void Main(string[] args)
        {
            Student s1 = new Student("Mert","Umul",19,"Computer Engineering");
            Identity i1 = new Identity();
            Console.WriteLine(i1.NAME);
            Console.WriteLine(i1.SURNAME);
            Console.WriteLine(i1.AGE);
            Console.WriteLine(i1.HOMETOWN);
            Console.WriteLine(i1.GENDER);
            Console.ReadKey();

        }

    }
}
