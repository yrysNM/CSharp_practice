namespace Polymorphism
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Function overloading (Static)
            PrintData p = new PrintData();

            // Call print to print integer
            p.print(5);

            // call print to print float
            p.print(500.263);

            // call print to print string
            p.print("Hello  C++");

            //(Dynamic) 
            Rectangle r = new Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("Area: ${0}", a);

        }
    }

    abstract class Shape
    {
        public abstract int area();
    }

    class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }

        public override int area()
        {
            Console.WriteLine("Rectangle class area: ");
            return (width * length);
        }
    }

    class PrintData
    {

        public void print(int i)
        {
            Console.WriteLine("Printing int: ${0}", i);
        }

        public void print(double f)
        {
            Console.WriteLine("Printing float: ${0}", f);
        }

        public void print(string s)
        {
            Console.WriteLine("Printing string: ${0}", s);
        }
    }
}