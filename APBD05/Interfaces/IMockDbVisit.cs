using APBD05.Models;

namespace APBD05.Interfaces;

public interface IMockDbVisit
{
    public List<Visit> GetByAnimal(Animal animal);
    public void Add(Visit visit);
}