namespace week3 {

    class Cars {
        protected string name;
        public string releaseDate;

        public Cars(string name, string releaseDate) {
            this.name = name; 
            this.releaseDate = releaseDate;
        }

        public Cars() {
            this.name = "no name";
        }


        public virtual void ShowInformation() {
            Console.WriteLine($"Cars name is {this.name} and release date {this.releaseDate}");
        } 

        public string Name {
            get {return this.name; }
            set {this.name = value; }
        } 
    }
}