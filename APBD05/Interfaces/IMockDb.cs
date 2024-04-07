namespace APBD05.Interfaces;

public interface IMockDb<T>
{
        public ICollection<Animal?> GetAll();

        public T? GetById(int id);
}