using System;

namespace String_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "This is a string example";
            Console.WriteLine("message={0}", message);
            Console.WriteLine("message.length={0}", message.Length);
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine("message={0}={1}",i, message[i]);

            }
            Console.Read();

        }
    }
}
