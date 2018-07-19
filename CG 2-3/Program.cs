using System;

namespace CG_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first string: ");
            string stringOne = Console.ReadLine();

            Console.Write("Enter your secondstring: ");
            string stringTwo = Console.ReadLine();

            Console.Write("Enter your third string: ");
            string stringThree = Console.ReadLine();

            Console.WriteLine("Here are your three strings: " + stringOne + stringTwo + stringThree);
            Console.ReadLine();
        }
    }
}
