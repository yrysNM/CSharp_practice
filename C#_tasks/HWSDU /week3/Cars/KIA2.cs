
namespace week3 {
    class KIA2: KIA {
        public new virtual void ShowInformation() {
            base.name = "KIA model2"; 
            Console.WriteLine($"New car {base.name}");
        }
    }
}