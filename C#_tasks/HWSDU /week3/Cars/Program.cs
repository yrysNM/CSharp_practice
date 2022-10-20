using static week3.Ferrari; 
using static week3.BWM;
using static week3.KIA;
using static week3.KIA2;
using static week3.Cars;
namespace week3 {
    class Program {
        public static void Main(string[] args) {
            Cars c = new Cars(); 
            Ferrari f = new Ferrari("F75 sport car", "2022");
            BWM b = new BWM("BWM x5", "2015");
            KIA k = new KIA();
            KIA2 k2 = new KIA2();
            Cars[] cars =  {f, b, k, k2}; 

            foreach(Cars car in cars ) {
                car.ShowInformation();
            } 
            k2.ShowInformation();
        }
    }
}