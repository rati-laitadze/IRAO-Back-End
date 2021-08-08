using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IRAOProject.Services
{
    public interface IRepository<T>
    {
        T Update(T entity);
        Task<IEnumerable<T>> All();
        Task<IEnumerable<T>> SubList(int Id);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
        Task SaveChange();
    }
}
