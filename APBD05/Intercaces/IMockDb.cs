namespace APBD05.Intercaces;

public interface IMockDb<T>
{
        public ICollection<T> GetAll();
}