using IRAOProject.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IRAOProject.Services
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        #region Properties    
        protected IRAOContext IRAOContext;
        #endregion

        #region Constructors
        public GenericRepository(IRAOContext IRAOContext)
        {
            this.IRAOContext = IRAOContext;
        }
        #endregion

        #region Methods
        public virtual async Task<IEnumerable<T>> All()
        {
            return await IRAOContext.Set<T>()
              .AsQueryable()
              .ToListAsync();
        }
        public virtual T Update(T entity)
        {
            IRAOContext.Entry(entity).State = EntityState.Modified;
            return IRAOContext.Update(entity)
                 .Entity;
        }
        public virtual async Task<IEnumerable<T>> SubList(int Id)
        {
            return await IRAOContext.Set<T>()
              .AsQueryable()
              .ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await IRAOContext.Set<T>()
                .AsQueryable()
                .Where(predicate).ToListAsync();
        }   
        public async Task SaveChange()
        {
            await IRAOContext.SaveChangesAsync();
        }
        #endregion
    }
}
