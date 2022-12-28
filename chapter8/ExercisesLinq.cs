namespace chapter8
{
    public class ExercisesLinq
    {
        public static void main()
        {
            //Numbers from range
            int[] listN1 = new int[] { 67, 92, 153, 15 };

            IEnumerable<int> rangeN = listN1.Where(n => n > 30 && n < 100);

            Console.WriteLine("-------------------------");
            printIntEnumerable(rangeN);


            //Last word containing letter
            string[] lastWord = new string[] { "plane", "ferry", "car", "bike" };

            var filterWord = lastWord.OrderBy(s => s).LastOrDefault(s => s.Contains("e"));

            Console.WriteLine(filterWord);


            //Unique values 
            string[] testStr = new string[] { "abc", "xyz", "klm", "xyz", "abc", "abc", "rst" };

            IEnumerable<string> uniqueStr = testStr.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key);

            string[] task3Test = new string[] { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };
            printStrEnumerable(uniqueStr);
            printStrEnumerable(task3Test);

            // TOp 5 numbers 
            int[] numbersTop = new int[] { 78, -9, 0, 23, 54, 21, 7, 86 };
            IEnumerable<int> top5Number = numbersTop.OrderByDescending(n => n).Take(5);

            printIntEnumerable(top5Number);


            // Square greater than 20 
            int[] greaterThan20 = new int[] { 7, 2, 30 };
            IEnumerable<int> greater20N = greaterThan20.Where(n => Math.Pow(n, 2) > 20);
            printIntEnumerable(greater20N);
        }


        public static void printIntEnumerable(IEnumerable<int> data)
        {
            foreach (var v in data)
            {
                Console.WriteLine(v);
            }
        }

        public static void printStrEnumerable(IEnumerable<string> s)
        {
            foreach (var str in s)
            {
                Console.WriteLine(str);
            }
        }
    }
}