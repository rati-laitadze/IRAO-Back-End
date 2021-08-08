using IRAOProject.DBContext;
using IRAOProject.Entities;
using IRAOProject.Services;
using System.Threading.Tasks;

namespace IRAOProject.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Properties
        private IRAOContext IRAOContext;
        private IRepository<Market> marketRepository;
        private IRepository<Company> companyRepository;
        private IRepository<MarketCompany> marketCompanyRepository;
        #endregion

        #region Constructors
        public UnitOfWork(IRAOContext IRAOContext)
        {
            this.IRAOContext = IRAOContext;
        }
        #endregion
        public IRepository<Market> MarkeRepository
        {
            get
            {
                if (marketRepository == null)
                {
                    marketRepository = new MarketRepository(IRAOContext);
                }
                return marketRepository;
            }
        }
        public IRepository<Company> CompanyRepository
        {
            get
            {
                if (companyRepository == null)
                {
                    companyRepository = new CompanyRepository(IRAOContext);
                }
                return companyRepository;
            }
        }
        public IRepository<MarketCompany> MarketCompanyRepository
        {
            get
            {
                if (marketCompanyRepository == null)
                {
                    marketCompanyRepository = new MarketCompanyRepository(IRAOContext);
                }
                return marketCompanyRepository;
            }
        }

        public async Task SaveChanges()
        {
            await IRAOContext.SaveChangesAsync();
        }
    }
}
