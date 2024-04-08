namespace APBD05.Models;

public class Animal(int id, string name, AnimalCategory category, double mass, Color color)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public AnimalCategory Category { get; set; } = category;
    public double Mass { get; set; } = mass;
    public Color Color { get; set; } = color;
}