using static System.Console;
using System.IO;
using System.Collections;

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

            //pattern matching with the switch statement 
            string path = @"./";

            Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

            string message = string.Empty;

            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    message = "The stream is a file that I can write to.";
                    break;
                case FileStream readOnlyFile:
                    message = "The stream is a read-only address";
                    break;
                case MemoryStream ms:
                    message = "The stream is a memory address";
                    break;
                default:
                    message = "The stream is some other type.";
                    break;
                case null:
                    message = "The stream is null";
                    break;

            }

            WriteLine(message);

            // simplifying switch statements with switch expressions
            message = s switch
            {
                FileStream writeableFile when s.CanWrite => "The stream is  file a that i can write to.",
                FileStream readOnlyFile => "The stream is a read-only file.",
                MemoryStream ms => "The stream is a memory address.",
                null => "The stream is null",
                _ => "The stream is some other type.",

            };

            WriteLine(message);

            //Looping with the do statment
            string password = string.Empty;
            do
            {
                Write("Enter your password: ");
                password = ReadLine();
            }
            while (password != "HI");
            WriteLine("Correct!");

            // looping with the foreach statment 
            string[] names = { "Adam", "Barry", "Charlie" };

            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }

            // undestaiding how foreach works internally 
            IEnumerator e = names.GetEnumerator();

            while (e.MoveNext())
            {
                string name = (string)e.Current;
                WriteLine($"{name} has {name.Length} characters.");
            }


            // converting from a binary object to a string 
            byte[] binaryObject = new byte[128];
            (new Random()).NextBytes(binaryObject);
            WriteLine("Binary Object as butes:");

            for (int index = 0; index < binaryObject.Length; index++)
            {
                Write($"{binaryObject[index]:X}");
            }

            WriteLine();

            // convert to Base64 string and ouput as text
            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($"Binary Object as Base64: {encoded}");

        }

        private static bool DoStuff()
        {

            WriteLine("I am doing some stuff");
            return true;
        }
    }
}