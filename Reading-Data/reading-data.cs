using System;

namespace Reading_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you, please enter your age: ");
            string input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old!");

        }
    }
}
