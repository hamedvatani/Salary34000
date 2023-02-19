﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Salary34000.Data;

#nullable disable

namespace Salary34000.Migrations
{
    [DbContext(typeof(SalaryContext))]
    partial class SalaryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("Salary34000.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "زیر دیپلم",
                            Score = 2
                        },
                        new
                        {
                            Id = 2,
                            Description = "دیپلم",
                            Score = 4
                        },
                        new
                        {
                            Id = 3,
                            Description = "فوق دیپلم",
                            Score = 6
                        },
                        new
                        {
                            Id = 4,
                            Description = "کارشناسی",
                            Score = 8
                        },
                        new
                        {
                            Id = 5,
                            Description = "کارشناسی ارشد",
                            Score = 10
                        },
                        new
                        {
                            Id = 6,
                            Description = "دکتری",
                            Score = 10
                        });
                });

            modelBuilder.Entity("Salary34000.Models.EmploymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EmploymentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "رسمی"
                        },
                        new
                        {
                            Id = 2,
                            Description = "قرارداد پاره‌وقت"
                        },
                        new
                        {
                            Id = 3,
                            Description = "قرارداد تمام‌وقت"
                        });
                });

            modelBuilder.Entity("Salary34000.Models.OrganizationUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("OrganizationUnits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "مدیریت پشتیبانی و خدمات"
                        },
                        new
                        {
                            Id = 2,
                            Description = "حوزه مدیر عامل"
                        },
                        new
                        {
                            Id = 3,
                            Description = "مدیریت حراست"
                        },
                        new
                        {
                            Id = 4,
                            Description = "مدیریت تدارکات"
                        },
                        new
                        {
                            Id = 5,
                            Description = "گروه فناوین"
                        },
                        new
                        {
                            Id = 6,
                            Description = "گروه پایش"
                        },
                        new
                        {
                            Id = 7,
                            Description = "گروه جم"
                        },
                        new
                        {
                            Id = 8,
                            Description = "گروه ارگ"
                        },
                        new
                        {
                            Id = 9,
                            Description = "گروه حافظ"
                        },
                        new
                        {
                            Id = 10,
                            Description = "مدیریت منابع انسانی "
                        },
                        new
                        {
                            Id = 11,
                            Description = "مدیریت مالی"
                        },
                        new
                        {
                            Id = 12,
                            Description = "گروه بصیر"
                        },
                        new
                        {
                            Id = 13,
                            Description = "مدیریت بازرگانی"
                        },
                        new
                        {
                            Id = 14,
                            Description = "گروه آفاق"
                        },
                        new
                        {
                            Id = 15,
                            Description = "مدیریت برنامه ریزی و نظارت"
                        },
                        new
                        {
                            Id = 16,
                            Description = "گروه فناوری و شتابدهی برنا"
                        },
                        new
                        {
                            Id = 17,
                            Description = "شیخ بهایی"
                        },
                        new
                        {
                            Id = 18,
                            Description = "گروه پویش"
                        },
                        new
                        {
                            Id = 19,
                            Description = "گروه ماهان"
                        },
                        new
                        {
                            Id = 20,
                            Description = "مدیریت فاوا"
                        },
                        new
                        {
                            Id = 21,
                            Description = "مدیریت تدارکات"
                        });
                });

            modelBuilder.Entity("Salary34000.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BirthCity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ChildrenCount")
                        .HasColumnType("INTEGER");

                    b.Property<double>("ConsolidatedInsurance")
                        .HasColumnType("REAL");

                    b.Property<string>("DocumentCity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DocumentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentSerial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("EducationAverage")
                        .HasColumnType("REAL");

                    b.Property<string>("EducationField")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EducationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EducationPlace")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EmploymentDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("EmploymentTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NationalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrganizationPost")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OrganizationUnitId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PersonelCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.HasIndex("EmploymentTypeId");

                    b.HasIndex("OrganizationUnitId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Salary34000.Models.Person", b =>
                {
                    b.HasOne("Salary34000.Models.Education", "Education")
                        .WithMany()
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Salary34000.Models.EmploymentType", "EmploymentType")
                        .WithMany()
                        .HasForeignKey("EmploymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Salary34000.Models.OrganizationUnit", "OrganizationUnit")
                        .WithMany()
                        .HasForeignKey("OrganizationUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Education");

                    b.Navigation("EmploymentType");

                    b.Navigation("OrganizationUnit");
                });
#pragma warning restore 612, 618
        }
    }
}
