using System.Collections.Generic;

namespace _2ndsemesterprojekt
{
    public interface iCatalog<T>
    {
        List<T> All { get; }
        void Create(T obj);
        T Read(int id);
        void Delete(int id);
        void Update(int id, T obj);
    }
}