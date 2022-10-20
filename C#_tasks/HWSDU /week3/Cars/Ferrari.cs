
namespace week3 {
    class Ferrari : Cars {
        public Ferrari(string name, string releaseDate) : base(name, releaseDate) {
            name = base.name;
            releaseDate = base.releaseDate;
        }
    }
}