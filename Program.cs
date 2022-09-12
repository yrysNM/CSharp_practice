using System;
using static SimpleCalculator.Calculator;

namespace SimpleCalculator
{
    class MainClass
    {
       


        public static void Main(string[] args)
        {
            //initial class
            Calculator objCalculator = new Calculator(false, false);


            Console.WriteLine("Simple calculator in C#");
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            objCalculator.FirstNumber = firstNumber;

            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            objCalculator.SecondNumber = secondNumber;

            Console.WriteLine("Enter the arithmetic methods(+, -, *, /):\t ");
            char arithmeticMethod = Convert.ToChar(Console.ReadLine());
            objCalculator.ArithmeticMethod = arithmeticMethod;

            objCalculator.showResult();
         
        }
    }
}
