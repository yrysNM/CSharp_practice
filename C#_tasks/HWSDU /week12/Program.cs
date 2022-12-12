
namespace week12
{

    class ExcpetionForError : Exception
    {

        public ShowErrorException(string err) : base(err)
        {

        }
    }

    class GenericTwoObj<T, S> where T : S where S : new()
    {
        public T[] obj = new T[10];
        GenericTwoObj()
        {
            obj[0] = "Continental";
        }

        public void AddValue(int index, T value)
        {
            try
            {
                if (index <= 0 && index > 10)
                {
                    throw new ExcpetionForError('not correct input');
                }
                else
                {
                    obj[index] = value;
                }
            }
            catch (ExcpetionForError e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public T? GetObjValues<T>(int key)
        {
            if (key >= 0 && key < 10)
            {
                return obj[key];
            }
            else
            {
                return default(T);
            }
        }
    }

    class CheckObjValue<T> : GenericTwoObj<int, string>
    {

        public void isContinental(string c)
        {
            if (c == obj[0])
            {
                Console.WriteLine("Accept to hunt");
            }
            else
            {
                Console.WriteLine("Not accept to hunt");
            }
        }
    }

    class Program
    {

        public static void reverseListArray<T>(IList<T> arr)
        {
            IList<T> revArr = (IList<T>)arr.Reverse();

            foreach (T value in revArr)
            {
                Console.Write(value.ToString() + " ");
            }

            Console.WriteLine();
        }



        public static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 5 };

            reverseListArray<int>(array);

        }
    }
}