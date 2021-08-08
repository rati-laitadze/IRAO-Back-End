using IRAOProject.DBContext;
using IRAOProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IRAOProject.Services
{
    public class MarketCompanyRepository : GenericRepository<MarketCompany>
    {
        #region Constructors
        public MarketCompanyRepository(IRAOContext IRAOContext) : base(IRAOContext)
        {
        }
        #endregion

        #region Methods
        public override async Task<IEnumerable<MarketCompany>> SubList(int Id)
        {
            return await IRAOContext.MarketCompanies.Where(Item => Item.MarketId == Id).Include(m => m.Company).AsQueryable().ToListAsync();
        }

        public override async  Task<IEnumerable<MarketCompany>> Find(Expression<Func<MarketCompany, bool>> predicate)
        {
            return await IRAOContext.MarketCompanies
                .AsQueryable()
                .Where(predicate).Include(m => m.Company).Include(c => c.Market).ToListAsync();
        }

        #endregion
    }
}
