namespace Complimentree.Models
{
    public class Tree(
        int id, string name, Tuple<double, double> location, double size, 
        string species, List<string> compliments
        )
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public Tuple<double, double> Location { get; set; } = location;
        public double Size { get; set; } = size;
        public string Species { get; set; } = species;
        public List<string> Compliments { get; set; } = compliments;
    }
}
