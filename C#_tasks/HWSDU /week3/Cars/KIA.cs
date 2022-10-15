namespace week3 {
    class KIA : Cars {
        public sealed override void ShowInformation() {
            base.name = "KIA";
            Console.WriteLine($"Awesome car {base.name}");
        }
    }
}