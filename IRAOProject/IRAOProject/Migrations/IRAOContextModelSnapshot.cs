﻿// <auto-generated />
using IRAOProject.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IRAOProject.Migrations
{
    [DbContext(typeof(IRAOContext))]
    partial class IRAOContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IRAOProject.Entities.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyId = 1,
                            CompanyName = "company1"
                        },
                        new
                        {
                            CompanyId = 2,
                            CompanyName = "company2"
                        },
                        new
                        {
                            CompanyId = 3,
                            CompanyName = "company3"
                        },
                        new
                        {
                            CompanyId = 4,
                            CompanyName = "company4"
                        },
                        new
                        {
                            CompanyId = 5,
                            CompanyName = "company5"
                        });
                });

            modelBuilder.Entity("IRAOProject.Entities.Market", b =>
                {
                    b.Property<int>("MarketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MarketName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("MarketId");

                    b.ToTable("Markets");

                    b.HasData(
                        new
                        {
                            MarketId = 1,
                            MarketName = "market1"
                        },
                        new
                        {
                            MarketId = 2,
                            MarketName = "market2"
                        },
                        new
                        {
                            MarketId = 3,
                            MarketName = "market3"
                        });
                });

            modelBuilder.Entity("IRAOProject.Entities.MarketCompany", b =>
                {
                    b.Property<int>("MarketId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<double>("CompanyPrice")
                        .HasColumnType("float");

                    b.HasKey("MarketId", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("MarketCompanies");

                    b.HasData(
                        new
                        {
                            MarketId = 1,
                            CompanyId = 1,
                            CompanyPrice = 100.0
                        },
                        new
                        {
                            MarketId = 2,
                            CompanyId = 1,
                            CompanyPrice = 100.0
                        },
                        new
                        {
                            MarketId = 3,
                            CompanyId = 1,
                            CompanyPrice = 100.0
                        },
                        new
                        {
                            MarketId = 1,
                            CompanyId = 2,
                            CompanyPrice = 100.0
                        },
                        new
                        {
                            MarketId = 2,
                            CompanyId = 2,
                            CompanyPrice = 100.0
                        },
                        new
                        {
                            MarketId = 3,
                            CompanyId = 2,
                            CompanyPrice = 100.0
                        },
                        new
                        {
                            MarketId = 1,
                            CompanyId = 3,
                            CompanyPrice = 100.0
                        },
                        new
                        {
                            MarketId = 2,
                            CompanyId = 3,
                            CompanyPrice = 100.0
                        },
                        new
                        {
                            MarketId = 3,
                            CompanyId = 3,
                            CompanyPrice = 100.0
                        },
                        new
                        {
                            MarketId = 1,
                            CompanyId = 4,
                            CompanyPrice = 100.0
                        },
                        new
                        {
                            MarketId = 2,
                            CompanyId = 4,
                            CompanyPrice = 100.0
                        },
                        new
                        {
                            MarketId = 3,
                            CompanyId = 4,
                            CompanyPrice = 100.0
                        },
                        new
                        {
                            MarketId = 1,
                            CompanyId = 5,
                            CompanyPrice = 100.0
                        },
                        new
                        {
                            MarketId = 2,
                            CompanyId = 5,
                            CompanyPrice = 100.0
                        },
                        new
                        {
                            MarketId = 3,
                            CompanyId = 5,
                            CompanyPrice = 100.0
                        });
                });

            modelBuilder.Entity("IRAOProject.Entities.MarketCompany", b =>
                {
                    b.HasOne("IRAOProject.Entities.Company", "Company")
                        .WithMany("MarketCompanies")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IRAOProject.Entities.Market", "Market")
                        .WithMany("MarketCompanies")
                        .HasForeignKey("MarketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Market");
                });

            modelBuilder.Entity("IRAOProject.Entities.Company", b =>
                {
                    b.Navigation("MarketCompanies");
                });

            modelBuilder.Entity("IRAOProject.Entities.Market", b =>
                {
                    b.Navigation("MarketCompanies");
                });
#pragma warning restore 612, 618
        }
    }
}
