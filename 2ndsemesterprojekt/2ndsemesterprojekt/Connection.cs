using System.Collections.Generic;
using System.Linq;

namespace _2ndsemesterprojekt
{
    public class Connection<T> : iCatalog<T> where T : class 
    {
        private T _obj { get; set; }
        private RiascaseContext _context;
        public Connection()
        {
               _context = new RiascaseContext();
        }

        public List<T> All
        {
            get { return _context.Set<T>().ToList(); }
        }

        public void Create(T obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
           T obj = _context.Find<T>(id);
            if (obj != null)
            {
                _context.Remove(obj);
            }
        }

        public T Read(int id)
        {
            return _context.Find<T>(id);
        }
    }
}