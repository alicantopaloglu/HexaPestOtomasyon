using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;
        public Repository()
        {
            _object = c.Set<T>();
        }

        public int Count(T p)
        {
            return _object.Count();
        }

        public bool Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
            return true;
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public bool Insert(T p)
        {
            try
            {
                _object.Add(p);
                c.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<T> List()
        {
            return _object.ToList();
        }
       

        public bool Update(T p)
        {
            c.SaveChanges();
            return true;
        }
    }
}
