using System;

namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of MathClass
            MathClass math = new MathClass();

            // Calling method by passing values normally
            math.PerformOperation(5, 10);

            // Calling method using named parameters
            math.PerformOperation(firstNumber: 20, secondNumber: 30);

            // Keeps the console window open
            Console.ReadLine();
        }
    }
}