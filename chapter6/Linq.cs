namespace chapter6
{
    class Linq
    {
        public static void main()
        {
            string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

            IEnumerable<string> selectedPeople = from p in people where p.ToUpper().StartsWith("T") orderby p select p;

            foreach (string person in selectedPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}