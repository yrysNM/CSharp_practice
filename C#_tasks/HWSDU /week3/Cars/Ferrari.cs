
namespace week3 {
    class Ferrari : Cars {
        public string Name {get; set;}
        public Ferrari(string name, string releaseDate) : base(name, releaseDate) {
            Name = name;
        }
    }
}