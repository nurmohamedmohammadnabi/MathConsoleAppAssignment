using System;

namespace MathConsoleApp
{
    // This class contains mathematical operations
    public class MathClass
    {
        // This method takes two integer parameters
        public void PerformOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer
            int result = firstNumber * firstNumber;

            // Display the result of the operation
            Console.WriteLine("Result: " + result);

            // Display the second integer
            Console.WriteLine("Second Number: " + secondNumber);
        }
    }
}