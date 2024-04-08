using APBD05.Interfaces;

namespace APBD05.Models;

public class MockDbVisit : IMockDbVisit
{
    private static IMockDbAnimals _mockDbAnimals = new MockDbAnimal();
    private ICollection<Visit> _animals = new List<Visit>()
    {
        new(new DateTime(2023, 12, 23), _mockDbAnimals.GetById(1), "descrition 1", 200),
        new(new DateTime(2023, 03, 13), _mockDbAnimals.GetById(1), "descrition 2", 250),
        new(new DateTime(2024, 02, 19), _mockDbAnimals.GetById(2), "descrition 3", 280),
        new(new DateTime(2023, 06, 27), _mockDbAnimals.GetById(3), "descrition 4", 400),
        new(new DateTime(2023, 03, 29), _mockDbAnimals.GetById(4), "descrition 5", 310),
        
    };

    public List<Visit> GetByAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }

    public void Add(Visit visit)
    {
        throw new NotImplementedException();
    }
}