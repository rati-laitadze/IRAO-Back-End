using IRAOProject.DBContext;
using IRAOProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRAOProject.Services
{
    public class MarketRepository : GenericRepository<Market>
    {
        #region Constructors
        public MarketRepository(IRAOContext IRAOContext) : base(IRAOContext)
        {
        }
        #endregion

    }
}
