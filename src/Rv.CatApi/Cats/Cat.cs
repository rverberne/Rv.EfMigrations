using NetTopologySuite.Geometries;

namespace Rv.CatApi.Cats
{
    public class Cat
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Summary { get; set; }
        public Point? Home { get; set; }
    }
}
