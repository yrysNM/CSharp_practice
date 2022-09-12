using System;

namespace SimpleCalculator
{
    class MainClass
    {
            
        public void printValue(int value) {
            Console.WriteLine($"Result: {value}");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Simple calculator in C#");
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the arithmetic methods(+, -, *, /):\t ");
            char arithmeticMethod = Convert.ToChar(Console.ReadLine());
            MainClass classMethods = new MainClass();


            // verification of which method is chosen   
            switch (arithmeticMethod) {
                case '+':
                    classMethods.printValue(firstNumber + secondNumber);
                    break;
                case '-':
                    classMethods.printValue(firstNumber - secondNumber);
                    break;
                case '*':
                    classMethods.printValue(firstNumber * secondNumber);
                    break;
                case '/':
                    classMethods.printValue(firstNumber / secondNumber);
                    break;
                default:
                    Console.WriteLine("Something is wrong");
                    break;
            }
        }
    }
}
