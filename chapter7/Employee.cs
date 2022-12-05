using static chapter7.Person;

namespace chapter7
{
    class Employee : Person
    {
        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}