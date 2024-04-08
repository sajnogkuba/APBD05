using APBD05.Models;

namespace APBD05.Interfaces;

public interface IMockDb<T>
{
        public ICollection<T?> GetAll();

        public T? GetById(int id);

        public void Add(T t);
        void Edit(int id, T T);
}