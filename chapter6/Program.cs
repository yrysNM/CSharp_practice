using static chapter6.Generic;
using static chapter6.Lambda;
// using static chapter6.Exception;
using static chapter6.Linq;

namespace chapter6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Temperature temp = new Temperature();

            try
            {
                temp.showTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }

            Generic.main();
            Lambda.main();
            //error becouse of TempIsZeroException!!!
            // Exception.main();
            Linq.main();
        }
    }

    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {

        }
    }

    public class Temperature
    {
        int temperature = 0;

        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature found!"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }
}