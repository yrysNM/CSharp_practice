using static week3.Ferrari; 
using static week3.BWM;
using static week3.KIA;
using static week3.Cars;
namespace week3 {
    class Program {
        public static void Main(string[] args) {
            Ferrari f = new Ferrari("F75 sport car", "2022");
            BWM b = new BWM("BWM x5", "2015");
            KIA k = new KIA();

            k.ShowInformation();
            f.ShowInformation();
            b.ShowInformation(); 
        }
    }
}