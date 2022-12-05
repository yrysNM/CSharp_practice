

namespace chapter6
{
    class Person<T, U>
    {
        public static T? code;
        public U Password { get; set; }
        public T ID { get; set; }
        public string Name { get; set; }

        public Person(T id, U password, string name)
        {
            this.ID = id;
            this.Name = name;
            this.Password = password;
        }
    }

    class Company<P>
    {
        public P CEO { get; set; }

        public Company(P ceo)
        {
            this.CEO = ceo;
        }
    }

    public class Generic
    {
        public static void main()
        {
            // Person<int> tom = new Person<int>(546, "Tom");
            // Person<int>.code = 1234;
            // Person<string> bob = new Person<string>("abc", "Bob");
            // Person<string>.code = "meta";
            // Company<Person<int>> microsoft = new Company<Person<int>>(tom);

            // int tomId = (int)tom.ID;
            // string bobId = (string)bob.ID;

            // Console.WriteLine("Name: {0}, id: {1}", microsoft.CEO.Name, tomId);
            // Console.WriteLine("Tom code Company: {0}, Bob code Company: {1}", Person<int>.code, Person<string>.code);

            // ----------------2act-----------------
            Person<int, string> john = new Person<int, string>(547, "qwer", "John");
            Console.WriteLine(john.ID);
            Console.WriteLine(john.Password);

            //method generic
            int x = 7;
            int y = 3;
            Swap<int>(ref x, ref y);
            Console.WriteLine($"x = {x} y = {y}");

        }

        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}