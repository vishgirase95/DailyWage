using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int numGen = num.Next(0,2);
            if (numGen == 1)
            {
                Console.WriteLine("Emp is present");
            }
            else
            {
                Console.WriteLine("Emp is absent");
            }
        }
    }
}
