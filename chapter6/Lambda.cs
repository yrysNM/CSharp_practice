namespace chapter6
{
    class Lambda
    {
        public static void main()
        {
            var hello = () =>
            {
                Console.WriteLine("Hello Lambda");
            };

            hello();
            hello();
            hello();

        }
    }
}