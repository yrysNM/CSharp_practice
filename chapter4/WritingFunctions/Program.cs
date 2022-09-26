using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table: ");
            for (int row = 1; row <= 12; row++)
            {
                WriteLine($"{row} * {number} = {row * number}");
            }
            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("ENter a number between 0 and 255: ");
                isNumber = byte.TryParse(ReadLine(), out byte number);

                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a void number!");
                }
            }
            while (isNumber);
        }

        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;
            switch (twoLetterRegionCode)
            {
                case "CH":
                    rate = 0.08M;
                    break;
                case "DK":
                case "NO":
                    rate = 0.25M;
                    break;
                case "GB":
                case "FR":
                    rate = 0.2M;
                    break;
                case "HU":
                    rate = 0.27M;
                    break;
                case "OR": // Oregon
                case "AK": // Alaska
                case "MT": // Montana
                    rate = 0.0M; break;
                case "ND": // North Dakota
                case "WI": // Wisconsin
                case "ME": // Maryland
                case "VA": // Virginia
                    rate = 0.05M;
                    break;
                case "CA": // California
                    rate = 0.0825M;
                    break;
                default: // most US states
                    rate = 0.06M;
                    break;
            }
            return amount * rate;
        }

        static void RunCalculateTax()
        {
            Write("Enter an amout: ");
            string amoutInText = (ReadLine());
            Write("Enter a two-letter region code: ");
            string region = ReadLine();

            if (decimal.TryParse(amoutInText, out decimal amout))
            {
                decimal taxToPay = CalculateTax(amout, region);
                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount!");
            }
        }

        /// <summary>
        ///  Pass a 32 -bit integer and it will be converted into its original equalient
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// 
        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    string numberAsText = number.ToString();
                    char lastDigit = numberAsText[numberAsText.Length - 1];
                    string suffix = string.Empty;
                    switch (lastDigit)
                    {
                        case '1':
                            suffix = "st";
                            break;
                        case '2':
                            suffix = "nd";
                            break;
                        case '3':
                            suffix = "rd";
                            break;
                        default:
                            suffix = "th";
                            break;
                    }
                    return $"{number}{suffix}";
            }
        }

        static void RunCardinalToOrdinal()
        {
            for (int number = 1; number <= 40; number++)
            {
                Write($"{CardinalToOrdinal(number)} ");

            }
            WriteLine();
        }

        static int Factorial(int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        static void RunFactorial()
        {
            bool isNumber;
            do
            {
                Write("Enter a number: ");

                isNumber = int.TryParse(ReadLine(), out int number);

                if (isNumber)
                {
                    WriteLine($"{number}! = {Factorial(number)}");
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            } while (isNumber);
        }

        static void Main(string[] args)
        {
            // RunTimesTable();
            // RunCalculateTax();
            // RunCardinalToOrdinal();
            RunFactorial();
        }
    }
}