using static System.Console;

namespace Lab4 {
    class Program {
        public static void Main(String[] args) {
            int [] arr = {0, 1, 2,3, 5};
            List<int> list = new List<int>(); 

            for(int x= 5; x < 20; x++) {
                list.Add(x);
            }

            // 1. Create a method that will reverse the order of any array.
            reverseArray<int>(arr);
            reverseArray<int>(list);

            TestGeneric<int, int> test = new TestGeneric<int, int>();

            test.AddOrUpdate(0, 50);
            test.AddOrUpdate(1, 65);
            test.AddOrUpdate(2, 69);
            test.AddOrUpdate(14, 40);


            WriteLine(test.GetData(12));

            TestGeneric2<int> test2 = new TestGeneric2<int>();
            test2.isAcceptTest(11);
        }

        public static void reverseArray<T>(IList<T> coll) {
            
            foreach(T item in coll.Reverse()) {
                Write(item.ToString() + " ");
            }

            WriteLine();
        }

        
    }

        // b)Write a generic class with at least 2 generic types.
         // c)Write constraints for both 2 generic types.
    class TestGeneric<T, S> where T : S where S : new() {
        public T[] _data = new T[10]; 

        public void AddOrUpdate(int index, T item) {
             // d) Create 2 custom exceptions and use them in try/catch blocks.
            try {
                if(index >= 0 && index< 10) {
                    _data[index] = item;
                }
            }catch(InvalidCastException e) {
                // WriteLine("Error {0}", e.Source);
                throw new ("Something wrong");
            }
        }

        public T GetData(int index) {
            //   d) Create 2 custom exceptions and use them in try/catch blocks.
            try {
                if(index >= 0 && index < 10) {
                    return _data[index];
                }
                
                return default(T);
            }catch(InvalidCastException e) {
                // WriteLine("Error {0}", e.Source);
                throw new ("Something wrong");
            }

        }
    }

    //e) Also write a second generic class that will derive from the first one (a).
    class TestGeneric2<T> : TestGeneric<int, int> {
        public T pass; 

        public void isAcceptTest (int item) {
            if(item > 10) {
                WriteLine("Accept");
            }else {
                WriteLine("Not accept");
            }
        }
    }
}