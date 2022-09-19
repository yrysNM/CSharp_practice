using System;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace chapter2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");

            //declare some unsed variables using types 
            //in additional assemblies 
            // System.Data.DataSet ds;
            // System.Net.Http.HttpClient client;

            // loop through the assemblies that this app references 
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                // loaod the assembly 
                var a = Assembly.Load(new AssemblyName(r.FullName));

                // declare a varialble to count the number of methods 
                int methodCount = 0;

                // loop through all the types in the assembly 
                foreach (var t in a.DefinedTypes)
                {
                    methodCount += t.GetMethods().Count();

                }

                Console.WriteLine("{0} types with {1} methods in {2} assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: methodCount,
                    arg2: r.Name);

            }

            // numbers
            Console.WriteLine("Using doubles: ");

            double doubleA = 0.1;
            double doubleB = 0.2;
            if (doubleA + doubleB == 0.3)
            {
                Console.WriteLine($"{doubleA} + {doubleB} equals 0.3");
            }
            else
            {
                Console.WriteLine($"${doubleA} + ${doubleB} is NOT equal 0.3");
            }

            Console.WriteLine("Using decimal: ");

            decimal doubleC = 0.1M; // M suffix means a decimal literal value
            decimal doubleD = 0.2M;

            if (doubleC + doubleD == 0.3M)
            {
                Console.WriteLine($"{doubleC} + {doubleD} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{doubleC} + {doubleD} is NOT equal 0.3");
            }

            //variables 
            // storing a string in a dynamic object
            dynamic anotherName = "Yrysbek";

            int length = anotherName.Length;
            Console.WriteLine($"String length: {length}; string: {anotherName}");

            int population = 66_000_000; // in 66 million in UK 
            double weight = 1.88;        // in kilogras
            decimal price = 4.990M;     // in pounds sterling 
            string fruit = "Apples";   // string use double-quotes 
            char letter = 'Y';         // chars use single-quotes 
            bool heppy = true;          // Boolens have value of true or false

            // good use ofvar because it avoids the repeated type 
            // as shown in the more verbose seconds statment
            // var xml1 = new XmlDocument();
            // XmlDataDocument xml2 = new XmlDataDocument();

            // bad use of var becouse we connot tell type so we 
            // should in the more verbose second statment
            // var file1 = File.CreateText(@"./test.txt");
            // StreamWriter file2 = File.CreateText(@"./test.txt");

            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");
        }
    }
}