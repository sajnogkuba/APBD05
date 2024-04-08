namespace APBD05.Models;

public class Animal(int id, string name, AnimalCategory category, double mass, Color color)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public AnimalCategory Category { get; set; } = category;
    public double Mass { get; set; } = mass;
    public Color Color { get; set; } = color;

    public override bool Equals(object? obj)
    {
        if (obj is not Animal)
        {
            return false;
        }

        var otherAnimal = (Animal)obj;
        return Id == otherAnimal.Id && Name == otherAnimal.Name && Category == otherAnimal.Category &&
            Color == otherAnimal.Color && Math.Abs(Mass - otherAnimal.Mass) < 0.001;
    }
}