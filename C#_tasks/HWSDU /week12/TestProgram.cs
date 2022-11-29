// using static System.Console;

// namespace week12
// {
//     public class GenericList<T> { 
//         public void Add(T input) {
//             WriteLine(input);
//         }

//     }

//     public class TestClass<T> {
//         public T name; 

//         public void SetName(T n) {
//             name = n;
//         }

//         public T getName() {
//             return name;
//         }
//     }

//     public class TestClass2 {
//         public void WriteGeneric<T>(T value) {
//             WriteLine(value.ToString());
//         }
//     }

//     class Program {
//         public static void Main  (String[] args) {
//             // GenericList<float> list1 = new GenericList<float>();
//             // list1.Add(1);

//             // GenericList<string> list2 = new GenericList<string>(); 
//             // list2.Add("");
            

//             // TestClass<int> intTest = new TestClass<int>(); 
//             // intTest.SetName(12);
//             // TestClass<string> stringTest = new TestClass<string>(); 
//             // stringTest.SetName("three");
//             // WriteLine(intTest.getName());
//             // WriteLine(stringTest.getName());
//             // TestClass2 test = new TestClass2();
//             // test.WriteGeneric("Hello");
//         }
//     }
// }