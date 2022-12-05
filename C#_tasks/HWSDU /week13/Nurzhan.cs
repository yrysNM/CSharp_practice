namespace week13
{
    public class Singer2
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

    }

    class Nurzhan
    {
        public static void main()
        {
            IEnumerable<Singer> singers = new List<Singer>()
            {
                new Singer(){Id = 1, FirstName = "Freddie", LastName = "Mercury", BirthYear=1964}
                , new Singer(){Id = 2, FirstName = "Elvis", LastName = "Presley", BirthYear = 1954}
                , new Singer(){Id = 3, FirstName = "Chuck", LastName = "Berry", BirthYear = 1954}
                , new Singer(){Id = 4, FirstName = "Ray", LastName = "Charles", BirthYear = 1950}
                , new Singer(){Id = 5, FirstName = "David", LastName = "Bowie", BirthYear = 1964}
            };

            string checkVowels = "aeiouy";
            int[] ints = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int totalYear = 0;
            string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth", "Metallica", "Cream", "Oasis", "Abba", "Blur", "Chic", "Eurythmics", "Genesis", "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers", "Noir Desir", "The Offspring", "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Tears for Fears", "Deep Purple", "KISS" };

            var threeLessThanN = ints.Where(num => num > 3).Select(num => num);
            var oddNumber = from number in ints where number % 2 == 1 select number;

            Console.WriteLine(string.Join(" ", threeLessThanN));
            Console.WriteLine(string.Join(" ", oddNumber.ToArray()));

            string[] numbersAsString = new string[] { "3", "1", "2", "4" };
            var convertNumber = numbersAsString.Select(n => Int16.Parse(n));

            foreach (int k in convertNumber)
            {
                Console.Write(" " + k.GetType() + " ");
            }
            Console.WriteLine();

            IEnumerable<int> lengthString = bands.Select(str => str.Length);
            foreach (int i in lengthString)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            foreach (Singer data in singers)
            {
                totalYear += data.BirthYear;
            }

            Console.WriteLine("Average year: " + totalYear / singers.Count());

            IEnumerable<string> orderByNames = singers.OrderBy(data => data.FirstName).Select(data => data.FirstName);


            foreach (string name in orderByNames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();


            IEnumerable<Singer> filterSinger = singers.Where(data => data.Id % 2 == 1 && data.FirstName.Length > 4 && data.LastName.Count(name => checkVowels.Contains(name)) >= 2).OrderBy(data => data.BirthYear).Select(data => data);

            showResultSingers(filterSinger);
        }

        public static void showResultSingers(IEnumerable<Singer> obj)
        {
            foreach (Singer data in obj)
            {
                Console.Write(data.FirstName + " ");
            }
            Console.WriteLine();
        }
    }
}