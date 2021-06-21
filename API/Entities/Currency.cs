using System.Dynamic;

namespace API.Entities
{
    public class Currency
    {
        public int Id { get; set; }
        public double Timestamp { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
    }
}