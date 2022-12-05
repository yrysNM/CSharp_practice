using static week13.Nurzhan;

namespace week13
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] ints = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            string[] numbersAsString = new string[] { "3", "1", "2", "4" };


            IEnumerable<int> moreThanThreeNumbers = ints.Where(n => n > 3).Select(n => n);
            IEnumerable<int> filterOddNumbers = ints.Where(n => n % 2 == 1).Select(num => num);

            Console.WriteLine("-----------------------1---------------------------");
            Console.WriteLine(string.Join("->", moreThanThreeNumbers));
            Console.WriteLine(string.Join("->", filterOddNumbers));



            var numbersAsInt = numbersAsString.Select(n => Int16.Parse(n));
            Console.WriteLine("-----------------------2---------------------------");
            foreach (int i in numbersAsInt)
            {
                Console.Write(i + " <--> " + i.GetType() + "\n");
            }



            Console.WriteLine("-----------------------3---------------------------");
            string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth", "Metallica", "Cream", "Oasis", "Abba", "Blur", "Chic", "Eurythmics", "Genesis", "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers", "Noir Desir", "The Offspring", "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Tears for Fears", "Deep Purple", "KISS" };
            IEnumerable<int> lengthStringsInArray = bands.Select(s => s.Length);

            foreach (int i in lengthStringsInArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



            Console.WriteLine("-----------------------4---------------------------");
            IEnumerable<Singer> singers = new List<Singer>()
            {
                new Singer(){Id = 1, FirstName = "Freddie", LastName = "Mercury", BirthYear=1964}
                , new Singer(){Id = 2, FirstName = "Elvis", LastName = "Presley", BirthYear = 1954}
                , new Singer(){Id = 3, FirstName = "Chuck", LastName = "Berry", BirthYear = 1954}
                , new Singer(){Id = 4, FirstName = "Ray", LastName = "Charles", BirthYear = 1950}
                , new Singer(){Id = 5, FirstName = "David", LastName = "Bowie", BirthYear = 1964}
            };

            int total = 0;
            foreach (Singer data in singers)
            {
                total += data.BirthYear;
            }

            Console.WriteLine("a. " + total / singers.Count());

            IEnumerable<string> orderByFirstName = singers.OrderBy(data => data.FirstName).Select(data => data.FirstName);


            foreach (string name in orderByFirstName)
            {
                Console.Write(name + " ->b. ");
            }
            Console.WriteLine();

            string vowels = "aeiouy";

            IEnumerable<Singer> filterData = from data in singers
                                             where data.Id % 2 == 1 && data.FirstName.Length > 4 && data.LastName.Count(s => vowels.Contains(s)) >= 2
                                             orderby data.BirthYear ascending
                                             select data;
            Console.Write("c. ");
            foreach (Singer name in filterData)
            {
                Console.Write(name.FirstName + " ");
            }
            Console.WriteLine();

            Nurzhan.main();
        }


    }

    public class Singer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

    }

}