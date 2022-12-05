// namespace chapter6
// {
//     class Exception
//     {
//         public static void main()
//         {
//             try
//             {
//                 int x = 5;
//                 int y = x / 0;
//                 Console.WriteLine($"Result: {y}");
//             }
//             catch (ExceptionDivider e)
//             {
//                 Console.WriteLine($"Exception {e.Message}");
//             }
//             finally
//             {
//                 Console.WriteLine("Block finally");
//             }
//             Console.WriteLine("The End");
//         }
//     }

//     public class ExceptionDivider : Exception
//     {
//         public ExceptionDivider(string message) : base(message)
//         {

//         }
//     }
// }