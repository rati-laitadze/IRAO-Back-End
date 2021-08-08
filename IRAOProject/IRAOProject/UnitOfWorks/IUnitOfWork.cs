using IRAOProject.Entities;
using IRAOProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRAOProject.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IRepository<Market> MarkeRepository { get; }
        IRepository<Company> CompanyRepository { get; }
        IRepository<MarketCompany> MarketCompanyRepository { get; }
        Task SaveChanges();
    }
}
