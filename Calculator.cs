using System;
namespace SimpleCalculator
{
    public class Calculator
    {
        public bool isNewCalculations, isEnd;
        public char arithmeticMethod;
        public int firstNumber, secondNumber;

        //properties
        public int FirstNumber 
        { 
            get { return firstNumber; }
            set { firstNumber = value; }
        }

        public int SecondNumber 
        {
            get { return secondNumber; }
            set { secondNumber = value; }
        }

        public char ArithmeticMethod
        {
            get { return arithmeticMethod; }
            set { arithmeticMethod = value; }
        }


        // constructor 
        public Calculator(bool isNewCalculations, bool isEnd)
        {
            this.isNewCalculations = isNewCalculations;
            this.isEnd = isEnd;
        }

           
        // verification of which method is chosen
        public void showResult()
        {
            switch (arithmeticMethod)
            {
                case '+':
                    printValue(firstNumber + secondNumber);
                    break;
                case '-':
                    printValue(firstNumber - secondNumber);
                    break;
                case '*':
                    printValue(firstNumber * secondNumber);
                    break;
                case '/':
                    printValue(firstNumber / secondNumber);
                    break;
                default:
                    Console.WriteLine("Something is wrong");
                    break;
            }
        }

        public void printValue (int value)
        {
            Console.WriteLine($"Result: {value}");
        }
    }
}
