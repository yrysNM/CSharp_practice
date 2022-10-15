namespace week3 {

    class BWM: Cars {
        string Name {get; set;}
        public BWM(string name, string releaseDate) : base(name, releaseDate) {
            Name = name;
        }
        public override void ShowInformation() {
            Console.WriteLine($"Germany car {this.Name} release date {this.releaseDate}");
        }
    }
}