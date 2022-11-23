using static System.Console;

namespace week12 {
    class Lab4 {
        public static void Main(String[] args) {
            int [] arr = {0, 1, 2,3, 5};
            List<int> list = new List<int>(); 

            for(int x= 5; x < 20; x++) {
                list.Add(x);
            }

            reverseArray<int>(arr);
            reverseArray<int>(list);
        }

        public static void reverseArray<T>(IList<T> coll) {
            // T length = coll.Length;
            // T middle = length / 2;

            // for(int i = 0; i <= middle ;i++) {
            //     int temp =  
            // }

            foreach(T item in coll) {
                Write(item.ToString() + " ");
            }
            WriteLine();
        }
    }
}