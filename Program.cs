using System;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The First Interger");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Second Interger");
            int second = Convert.ToInt32(Console.ReadLine());

            int result = first + second;
            Console.WriteLine($"The result is {result}");

            Console.ReadKey();
        }
    }
}
