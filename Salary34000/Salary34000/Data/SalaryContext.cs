using Microsoft.EntityFrameworkCore;
using Salary34000.Models;

namespace Salary34000.Data;

public class SalaryContext : DbContext
{
    public DbSet<Person> Persons { get; set; } = null!;
    public DbSet<EmploymentType> EmploymentTypes { get; set; } = null!;
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; } = null!;
    public DbSet<Education> Educations { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"DataSource=salary34000.db;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmploymentType>().HasData(
            new EmploymentType
            {
                Id = 1,
                Description = "رسمی"
            },
            new EmploymentType
            {
                Id = 2,
                Description = "قرارداد پاره‌وقت"
            },
            new EmploymentType
            {
                Id = 3,
                Description = "قرارداد تمام‌وقت"
            }
        );
        modelBuilder.Entity<OrganizationUnit>().HasData(
            new OrganizationUnit
            {
                Id = 1,
                Description = "مدیریت پشتیبانی و خدمات"
            },
            new OrganizationUnit
            {
                Id = 2,
                Description = "حوزه مدیر عامل"
            },
            new OrganizationUnit
            {
                Id = 3,
                Description = "مدیریت حراست"
            },
            new OrganizationUnit
            {
                Id = 4,
                Description = "مدیریت تدارکات"
            },
            new OrganizationUnit
            {
                Id = 5,
                Description = "گروه فناوین"
            },
            new OrganizationUnit
            {
                Id = 6,
                Description = "گروه پایش"
            },
            new OrganizationUnit
            {
                Id = 7,
                Description = "گروه جم"
            },
            new OrganizationUnit
            {
                Id = 8,
                Description = "گروه ارگ"
            },
            new OrganizationUnit
            {
                Id = 9,
                Description = "گروه حافظ"
            },
            new OrganizationUnit
            {
                Id = 10,
                Description = "مدیریت منابع انسانی "
            },
            new OrganizationUnit
            {
                Id = 11,
                Description = "مدیریت مالی"
            },
            new OrganizationUnit
            {
                Id = 12,
                Description = "گروه بصیر"
            },
            new OrganizationUnit
            {
                Id = 13,
                Description = "مدیریت بازرگانی"
            },
            new OrganizationUnit
            {
                Id = 14,
                Description = "گروه آفاق"
            },
            new OrganizationUnit
            {
                Id = 15,
                Description = "مدیریت برنامه ریزی و نظارت"
            },
            new OrganizationUnit
            {
                Id = 16,
                Description = "گروه فناوری و شتابدهی برنا"
            },
            new OrganizationUnit
            {
                Id = 17,
                Description = "شیخ بهایی"
            },
            new OrganizationUnit
            {
                Id = 18,
                Description = "گروه پویش"
            },
            new OrganizationUnit
            {
                Id = 19,
                Description = "گروه ماهان"
            },
            new OrganizationUnit
            {
                Id = 20,
                Description = "مدیریت فاوا"
            },
            new OrganizationUnit
            {
                Id = 21,
                Description = "مدیریت تدارکات"
            }
        );
        modelBuilder.Entity<Education>().HasData(
            new Education
            {
                Id = 1,
                Description = "زیر دیپلم",
                Score = 2
            },
            new Education
            {
                Id = 2,
                Description = "دیپلم",
                Score = 4
            },
            new Education
            {
                Id = 3,
                Description = "فوق دیپلم",
                Score = 6
            },
            new Education
            {
                Id = 4,
                Description = "کارشناسی",
                Score = 8
            },
            new Education
            {
                Id = 5,
                Description = "کارشناسی ارشد",
                Score = 10
            },
            new Education
            {
                Id = 6,
                Description = "دکتری",
                Score = 10
            }
        );
    }
}