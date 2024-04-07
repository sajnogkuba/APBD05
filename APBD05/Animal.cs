using APBD05.Properties;

namespace APBD05;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public AnimalCategory Category { get; set; }
    public double Mass { get; set; }
    public Color Color { get; set; }
}