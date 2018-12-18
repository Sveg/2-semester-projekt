using System.Collections.Generic;
using System.Linq;

namespace _2ndsemesterprojekt
{
    public class Catalog<T> : iCatalog<T> where T : class, IDomainClass
    {
        private T _obj { get; set; }
        private RiascaseContext _context;
        public Catalog()
        {
               _context = new RiascaseContext();
        }

        public List<T> All
        {
            get { return _context.Set<T>().ToList(); }
        }

        public void Create(T obj)
        {
            var ids = All.Select(o => o.GetId());
            int id = !ids.Any() ? 1 : All.Select(o => o.GetId()).Max() + 1;
            obj.SetId(id);

            _context.Add(obj);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
           T obj = _context.Find<T>(id);
            if (obj != null)
            {
                _context.Remove(obj);
                _context.SaveChanges();
            }
            
        }

        public T Read(int id)
        {
            return _context.Find<T>(id);
        }

        public void Update(int id, T obj)
        {
            T oldObj = Read(id);
            if (oldObj != null)
            {
                Delete(id);
                _context.Add(obj);
                _context.SaveChanges();
            }
            
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}