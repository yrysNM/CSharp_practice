namespace chapter7
{
    class Person
    {
        private string _name = "";

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
}