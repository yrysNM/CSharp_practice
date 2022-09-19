using static System.Console;

namespace Operators
{

    class Program
    {
        static bool a = true;

        static void Main(string[] args)
        {
            WriteLine($"a & DoStuff()  = {a & DoStuff()}");


            // pattern matching with the if statment 
            object o = 4;
            int j = 3;
            if (o is int i)
            {
                WriteLine($"{i} * {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int  so it canot multiply!");
            }

        // branching with the switch statement 
        A_label1:
            var number = (new Random()).Next(1, 7);
            WriteLine($"My random number is {number}");

            switch (number)
            {
                case 1:
                    WriteLine("One");
                    break;
                case 2:
                    WriteLine("Two");
                    break;
                case 3:
                    WriteLine("Three");
                    break;
                case 4:
                    WriteLine("Four");
                    break;
                case 5:
                    WriteLine("Five");
                    break;
                default:
                    WriteLine("Default");
                    break;
            };
        }

        private static bool DoStuff()
        {

            WriteLine("I am doing some stuff");
            return true;
        }
    }
}