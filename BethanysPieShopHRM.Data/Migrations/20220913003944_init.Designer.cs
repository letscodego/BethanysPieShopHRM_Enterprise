﻿// <auto-generated />
using System;
using BethanysPieShopHRM.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BethanysPieShopHRM.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220913003944_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnswerId"), 1L, 1);

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SurveyId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("SurveyId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "Belgium"
                        },
                        new
                        {
                            CountryId = 2,
                            Name = "Germany"
                        },
                        new
                        {
                            CountryId = 3,
                            Name = "Netherlands"
                        },
                        new
                        {
                            CountryId = 4,
                            Name = "USA"
                        },
                        new
                        {
                            CountryId = 5,
                            Name = "Japan"
                        },
                        new
                        {
                            CountryId = 6,
                            Name = "China"
                        },
                        new
                        {
                            CountryId = 7,
                            Name = "UK"
                        },
                        new
                        {
                            CountryId = 8,
                            Name = "France"
                        },
                        new
                        {
                            CountryId = 9,
                            Name = "Brazil"
                        });
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Currency", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CurrencyId"), 1L, 1);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("USExchange")
                        .HasColumnType("float");

                    b.HasKey("CurrencyId");

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            CurrencyId = 1,
                            Country = "USA",
                            Name = "US Dollars",
                            USExchange = 1.0
                        },
                        new
                        {
                            CurrencyId = 2,
                            Country = "Germany",
                            Name = "Euro",
                            USExchange = 1.1399999999999999
                        });
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExitDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsFTE")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOPEX")
                        .HasColumnType("bit");

                    b.Property<int>("JobCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("JoinedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Smoker")
                        .HasColumnType("bit");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CountryId");

                    b.HasIndex("JobCategoryId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            BirthDate = new DateTime(1979, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Brussels",
                            Comment = "Lorem Ipsum",
                            CountryId = 1,
                            Email = "bethany@bethanyspieshop.com",
                            FirstName = "Bethany",
                            Gender = 1,
                            IsFTE = false,
                            IsOPEX = false,
                            JobCategoryId = 1,
                            JoinedDate = new DateTime(2015, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Smith",
                            Latitude = 50.850299999999997,
                            Longitude = 4.3517000000000001,
                            MaritalStatus = 1,
                            PhoneNumber = "324777888773",
                            Smoker = false,
                            Street = "Grote Markt 1",
                            Zip = "1000"
                        },
                        new
                        {
                            EmployeeId = 2,
                            BirthDate = new DateTime(1979, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "New York",
                            Comment = "Lorem Ipsum",
                            CountryId = 1,
                            Email = "bob@bethanyspieshop.com",
                            FirstName = "Bob",
                            Gender = 1,
                            IsFTE = false,
                            IsOPEX = false,
                            JobCategoryId = 1,
                            JoinedDate = new DateTime(2015, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Smith",
                            Latitude = 46.850299999999997,
                            Longitude = 48.351700000000001,
                            MaritalStatus = 1,
                            PhoneNumber = "55512312321",
                            Smoker = false,
                            Street = "Apple Road",
                            Zip = "59555"
                        });
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Expense", b =>
                {
                    b.Property<int>("ExpenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpenseId"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<double>("CoveredAmount")
                        .HasColumnType("float");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ExpenseType")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExpenseId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            ExpenseId = 1,
                            Amount = 900.0,
                            CoveredAmount = 0.0,
                            CurrencyId = 1,
                            Date = new DateTime(2022, 9, 12, 17, 39, 44, 556, DateTimeKind.Local).AddTicks(9105),
                            Description = "I went to a conference",
                            EmployeeId = 1,
                            ExpenseType = 2,
                            Status = 0,
                            Title = "Conference Expense"
                        });
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.HRTask", b =>
                {
                    b.Property<int>("HRTaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HRTaskId"), 1L, 1);

                    b.Property<int>("AssignedTo")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HRTaskId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            HRTaskId = 1,
                            AssignedTo = 0,
                            Description = "Joe is having an issue with his account login, please look into it.",
                            Status = 0,
                            Title = "Employee Onboarding"
                        },
                        new
                        {
                            HRTaskId = 2,
                            AssignedTo = 0,
                            Description = "The fridge needs to be cleaned out and people are ignoring the weekly rotation.",
                            Status = 0,
                            Title = "Kitchen Duty"
                        },
                        new
                        {
                            HRTaskId = 3,
                            AssignedTo = 0,
                            Description = "Schedule a welcome lunch for our new employees",
                            Status = 0,
                            Title = "Welcome Lunch"
                        },
                        new
                        {
                            HRTaskId = 4,
                            AssignedTo = 0,
                            Description = "We need to schedule intern interviews for the fall semester.",
                            Status = 0,
                            Title = "Intern interviews"
                        });
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.JobCategory", b =>
                {
                    b.Property<int>("JobCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobCategoryId"), 1L, 1);

                    b.Property<string>("JobCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobCategoryId");

                    b.ToTable("JobCategories");

                    b.HasData(
                        new
                        {
                            JobCategoryId = 1,
                            JobCategoryName = "Pie research"
                        },
                        new
                        {
                            JobCategoryId = 2,
                            JobCategoryName = "Sales"
                        },
                        new
                        {
                            JobCategoryId = 3,
                            JobCategoryName = "Management"
                        },
                        new
                        {
                            JobCategoryId = 4,
                            JobCategoryName = "Store staff"
                        },
                        new
                        {
                            JobCategoryId = 5,
                            JobCategoryName = "Finance"
                        },
                        new
                        {
                            JobCategoryId = 6,
                            JobCategoryName = "QA"
                        },
                        new
                        {
                            JobCategoryId = 7,
                            JobCategoryName = "IT"
                        },
                        new
                        {
                            JobCategoryId = 8,
                            JobCategoryName = "Cleaning"
                        },
                        new
                        {
                            JobCategoryId = 9,
                            JobCategoryName = "Bakery"
                        });
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Survey", b =>
                {
                    b.Property<int>("SurveyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SurveyId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SurveyId");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Answer", b =>
                {
                    b.HasOne("BethanysPieShopHRM.Shared.Survey", "Survey")
                        .WithMany("Answers")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Employee", b =>
                {
                    b.HasOne("BethanysPieShopHRM.Shared.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BethanysPieShopHRM.Shared.JobCategory", "JobCategory")
                        .WithMany()
                        .HasForeignKey("JobCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("JobCategory");
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Expense", b =>
                {
                    b.HasOne("BethanysPieShopHRM.Shared.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BethanysPieShopHRM.Shared.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Currency");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Survey", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}