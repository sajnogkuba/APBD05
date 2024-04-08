using APBD05.Interfaces;
using APBD05.Models;

namespace APBD05;

public class MockDb : IMockDb<Animal>
{
    private ICollection<Animal> _animals = new List<Animal>()
    {
        new(1, "Max", AnimalCategory.Dog, 15.5, Color.Brown),
        new(2, "Bella", AnimalCategory.Dog, 20.3, Color.Black),
        new(3, "Luna", AnimalCategory.Cat, 3.5, Color.White),
        new(4, "Simba", AnimalCategory.Cat, 4.2, Color.Silver),
        new(5, "Rocky", AnimalCategory.Dog, 12.8, Color.Grey),
        new(6, "Whiskers", AnimalCategory.Cat, 2.8, Color.Spotted),
        new(7, "Tweety", AnimalCategory.Bird, 0.25, Color.Yellow),
        new(8, "Thunder", AnimalCategory.Hamster, 550, Color.Brown),
        new(9, "Sky", AnimalCategory.Bird, 0.12, Color.Blue),
        new(10, "Daisy", AnimalCategory.Cow, 675, Color.Spotted),
    };


    public ICollection<Animal?> GetAll()
    {
        return _animals;
    }

    public Animal? GetById(int id)
    {
        return this._animals.FirstOrDefault(a => a != null && a.Id == id);
    }

    public void Add(Animal animal)
    {
        _animals.Add(animal);
    }
}