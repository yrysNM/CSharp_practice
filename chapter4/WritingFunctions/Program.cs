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
            string amoutInText = ReadLine();
            Write("Enter a two-letter region code: ");
            string region = ReadLine();

            if (decimal.TryParse(amountInText, out decimal amout))
            {
                decimal taxPay = CalculateTax(amout, region);
                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount!");
            }
        }

        static void Main(string[] args)
        {
            // RunTimesTable();
            RunCalculateTax();
        }
    }
}