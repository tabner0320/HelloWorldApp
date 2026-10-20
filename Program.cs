using System;

namespace HelloWorldApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Generate equations for addition and subtraction:");

        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            int num1 = random.Next(1, 100);
            int num2 = random.Next(1, 100);

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine();
        }
    }
}