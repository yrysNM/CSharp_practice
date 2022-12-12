namespace week13
{
    public class Singer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int BirthYear { get; set; }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            int[] ints = new int[] {
                1, 2, 3, 4, 5, 6, 7, 8
            };

            IEnumerable<int> numbersGreaterThanThree = ints.Where(n => n > 3);
            Console.WriteLine(string.Join("<=", numbersGreaterThanThree));

            var oddNumbers = ints.Where(n => n % 2 == 1);
            Console.WriteLine(string.Join("--", oddNumbers));


            var numbersAsString = new List<string>{
                "3", "1", "2", "4"
            };

            IEnumerable<int> convertToInt = numbersAsString.Select(n => Int32.Parse(n));
            Console.WriteLine(convertToInt.First().GetType());


            string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth", "Metallica", "Cream", "Oasis", "Abba", "Blur", "Chic", "Eurythmics", "Genesis", "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers", "Noir Desir", "The Offspring", "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Tears for Fears", "Deep Purple", "KISS" };

            var bandsLength = bands.Select(s => $"{s}: {s.Length}");

            foreach (string strs in bandsLength)
            {
                Console.WriteLine(strs);
            }

            IEnumerable<Singer> singers = new List<Singer>()
            {
                new Singer(){Id = 1, FirstName = "Freddie", LastName = "Mercury", BirthYear=1964}
                , new Singer(){Id = 2, FirstName = "Elvis", LastName = "Presley", BirthYear = 1954}
                , new Singer(){Id = 3, FirstName = "Chuck", LastName = "Berry", BirthYear = 1954}
                , new Singer(){Id = 4, FirstName = "Ray", LastName = "Charles", BirthYear = 1950}
                , new Singer(){Id = 5, FirstName = "David", LastName = "Bowie", BirthYear = 1964}
            };

            var meanOfBirthYear = singers.Average(s => s.BirthYear);
            Console.WriteLine(string.Join(" ", Math.Floor(meanOfBirthYear)));

            var orderFirstNames = singers.OrderBy(s => s.FirstName);

            Console.WriteLine(string.Join(" ", orderFirstNames.First().FirstName));

            string vowels = "aeiouy";
            var filterSingers = singers.Where(s => s.Id % 2 == 1 && s.FirstName.Length > 4 && s.LastName.Count(l => vowels.Contains(l)) >= 2).OrderBy(s => s.BirthYear);

            foreach (Singer s in filterSingers)
            {
                Console.WriteLine($"Surname and Name: {s.FirstName} {s.LastName}");
            }
        }
    }
}