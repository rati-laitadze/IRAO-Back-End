using IRAOProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRAOProject.DBContext
{
    public class IRAOContext : DbContext
    {
        #region Constructors
        public IRAOContext(DbContextOptions<IRAOContext> option) : base(option)
        {

        }
        #endregion

        #region Properties
        public DbSet<Company> Companies { get; set; }
        public DbSet<Market> Markets { get; set; }
        public DbSet<MarketCompany> MarketCompanies { get; set; }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MarketCompany>()
                .HasKey(mc => new { mc.MarketId, mc.CompanyId });
            modelBuilder.Entity<MarketCompany>()
                .HasOne(mc => mc.Market)
                .WithMany(m => m.MarketCompanies)
                .HasForeignKey(mc => mc.MarketId);
            modelBuilder.Entity<MarketCompany>()
                .HasOne(mc => mc.Company)
                .WithMany(c => c.MarketCompanies)
                .HasForeignKey(mc => mc.CompanyId);

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    CompanyId = 1,
                    CompanyName = "company1",
                },
                new Company
                {
                    CompanyId = 2,
                    CompanyName = "company2",
                },
                new Company
                {
                    CompanyId = 3,
                    CompanyName = "company3",
                },
                new Company
                {
                    CompanyId = 4,
                    CompanyName = "company4",
                },
                new Company
                {
                    CompanyId = 5,
                    CompanyName = "company5",
                }
                );

            modelBuilder.Entity<Market>().HasData(
                new Market
                {
                    MarketId = 1,
                    MarketName = "market1"
                },
                 new Market
                 {
                     MarketId = 2,
                     MarketName = "market2"
                 }, new Market
                 {
                     MarketId = 3,
                     MarketName = "market3"
                 }
                );
            modelBuilder.Entity<MarketCompany>().HasData(
                new MarketCompany
                {
                    CompanyId = 1,
                    MarketId = 1,
                    CompanyPrice = 100
                }, new MarketCompany
                {
                    CompanyId = 1,
                    MarketId = 2,
                    CompanyPrice = 100
                }, new MarketCompany
                {
                    CompanyId = 1,
                    MarketId = 3,
                    CompanyPrice = 100
                }, new MarketCompany
                {
                    CompanyId = 2,
                    MarketId = 1,
                    CompanyPrice = 100
                }, new MarketCompany
                {
                    CompanyId = 2,
                    MarketId = 2,
                    CompanyPrice = 100
                }, new MarketCompany
                {
                    CompanyId = 2,
                    MarketId = 3,
                    CompanyPrice = 100
                }, new MarketCompany
                {
                    CompanyId = 3,
                    MarketId = 1,
                    CompanyPrice = 100
                }, new MarketCompany
                {
                    CompanyId = 3,
                    MarketId = 2,
                    CompanyPrice = 100
                }, new MarketCompany
                {
                    CompanyId = 3,
                    MarketId = 3,
                    CompanyPrice = 100
                }, new MarketCompany
                {
                    CompanyId = 4,
                    MarketId = 1,
                    CompanyPrice = 100
                }, new MarketCompany
                {
                    CompanyId = 4,
                    MarketId = 2,
                    CompanyPrice = 100
                }, new MarketCompany
                {
                    CompanyId = 4,
                    MarketId = 3,
                    CompanyPrice = 100
                }, new MarketCompany
                {
                    CompanyId = 5,
                    MarketId = 1,
                    CompanyPrice = 100
                }, new MarketCompany
                {
                    CompanyId = 5,
                    MarketId = 2,
                    CompanyPrice = 100
                }, new MarketCompany
                {
                    CompanyId = 5,
                    MarketId = 3,
                    CompanyPrice = 100
                }
                );
        }
        #endregion
    }
}
