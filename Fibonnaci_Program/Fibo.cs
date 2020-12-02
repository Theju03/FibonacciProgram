using System;
  
namespace Fibonacci_Program
{
    /// <summary>Class <c> MainClass </c> models for finding the nth Number of the Fibonacci Series plane.</summary>
    class Fibo
    {
        /// <summary>This is the entry point of the Fibonacci class  program. </summary>
        public static void Main(string[] args)
        {
            long value;
            long inputnum;

            Console.WriteLine("Enter the number: ");
            inputnum = ValidInputCheck(Console.ReadLine());

            value = Fibonacci(inputnum);
            Console.WriteLine($"The {inputnum}th number in fibonacci series is {value}");
        }


        /// <summary>This is the method for validating the input </summary>
        public static long ValidInputCheck(string val)
        {
            long inputValue;
            bool success = long.TryParse(val, out inputValue);
            if (success && Convert.ToInt64(val) > 0)
            {
                return inputValue;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>This is the method for calculating the nth Fibonacci number </summary>
        public static long Fibonacci(long input)
        {

            if (input <= 1)
            {
                return input;
            }
            else
            {
                return (Fibonacci(input - 1) + Fibonacci(input - 2));
            }

        }
    }
}
