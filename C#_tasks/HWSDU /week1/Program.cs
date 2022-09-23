using static System.Console;
using System.Globalization;
namespace week1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // task 1
            WriteLine("Enter chacter vowel: ");
            char character = Convert.ToChar(ReadLine());

            if (Char.ToLower(character) == character)
            {
                if (character == 'a' || character == 'e' || character == 'i' ||
                        character == 'o' || character == 'u')
                {

                    WriteLine("It's a lowercase vowel.");
                }
                else
                {
                    WriteLine("Its not a lowercase vowel.");
                }
            }
            else
            {
                WriteLine("Its not a lowercase character.");
            }

            //task 2 
            WriteLine("Enter first number:  ");
            int firstNumber = Convert.ToInt32(ReadLine());
            WriteLine("Enter second number:  ");
            int secondNumber = Convert.ToInt32(ReadLine());

            if (firstNumber % 2 == 0 && secondNumber % 2 == 0 ||
                firstNumber % 2 == 1 && secondNumber % 2 == 1)
            {
                WriteLine(true);
            }
            else
            {
                WriteLine(false);
            }

            //task 3 
            WriteLine("Enter the distance(meters): ");
            double distance = Convert.ToDouble(ReadLine());
            WriteLine("Enter timeSec(hour): ");
            double hour = Convert.ToDouble(ReadLine());
            WriteLine("Enter timeSec(minutes): ");
            double minute = Convert.ToDouble(ReadLine());
            WriteLine("Enter timeSec(seconds): ");
            double seconds = Convert.ToDouble(ReadLine());

            double convertSecond = (hour * 3600) + (minute * 60) + seconds;

            // formula U = S / t;
            double uMeterSec = distance / convertSecond;
            WriteLine($"Your speed in meters/sec is {uMeterSec}");
            double uKmHour = (distance / 1000) / (convertSecond / 3600);
            WriteLine($"Your speed in km/hour is {uKmHour}");
            double uMlHour = uKmHour / 1.609;
            WriteLine($"Your speed in miles/h is {uMlHour}");

            //task 4 
            WriteLine("Input the value for X coordinate: ");
            int x = Convert.ToInt32(ReadLine());
            WriteLine("Input the value for Y coordinate:  ");
            int y = Convert.ToInt32(ReadLine());

            if (x > 0 && y > 0)
            {
                WriteLine($"The coordinate point ({x} {y}) lies in the First quandrant");
            }
            else if (x < 0 && y > 0)
            {
                WriteLine($"The coordinate point ({x}, {y} lies in the Second quandrant)");
            }
            else if (x < 0 && y < 0)
            {
                WriteLine($"The coordinate point ({x}, {y} lies in the Third quandrant)");
            }
            else if (x > 0 && y < 0)
            {
                WriteLine($"The coordinate point ({x}, {y} lies in the Fourth quandrant)");
            }
            else if (x == 0 && y == 0)
            {
                WriteLine($"The coordinate point ({x}, {y} lies in the Center quandrant)");
            }

            //task 5 
            WriteLine("Input numnber of rows: ");
            int rows = Convert.ToInt32(ReadLine());
            int count = rows + 4 - 1;
            int numbers = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int k = count; k >= 1; k--)
                {
                    Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    // numbers++;
                    Write($"{numbers++} ");
                }
                Write("\n");
                count--;
            }
        }
    }
}