using IRAOProject.DBContext;
using IRAOProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRAOProject.Services
{
    public class CompanyRepository : GenericRepository<Company>
    {
        #region Constructors
        public CompanyRepository(IRAOContext IRAOContext) : base(IRAOContext)
        {
        }
        #endregion
    }
}
