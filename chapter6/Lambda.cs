namespace chapter6
{
    class Lambda
    {
        public static void main()
        {
            int Square(int num) => num * num;

            Console.WriteLine(Square(5));

            void Message(string msg) => Console.WriteLine(msg);

            Message("Hello world!");

            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}";
                Console.WriteLine(greeting);
            };

            greet("Yrys");
        }
    }
}