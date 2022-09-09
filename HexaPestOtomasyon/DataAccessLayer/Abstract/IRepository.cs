using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        bool Insert(T p);
        bool Update(T p);
        bool Delete(T p);
        int Count(T p);
        List<T> List();
        T GetById(int id);
        T Find(Expression<Func<T, bool>> where);
    }
}
