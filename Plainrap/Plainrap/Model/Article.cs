namespace Plainrap.Model
{
    public class Article
    {
        private string name { get; }
        private string description { get; set; }
        private float amount { get; set; }

        public Article(string name)
        {
            this.name = name;
        }

        public Article() { }
    }
}
