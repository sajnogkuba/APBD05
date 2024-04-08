using APBD05.Models;

namespace APBD05.Interfaces;

public interface IMockDbAnimals
{
        public ICollection<Animal?> GetAll();
        public Animal? GetById(int id);
        public void Add(Animal t);
        void Edit(int id, Animal T);
        void Delete(int id);
}