using static chapter7.Person;
using static chapter7.Employee;

namespace chapter7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person { Name = "Tom" };
            person.Print();
            person = new Employee { Name = "Sam" };
            person.Print();

        }
    }
}