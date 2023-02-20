using Microsoft.EntityFrameworkCore;
using Salary34000.Models;

namespace Salary34000.Data;

public class SalaryContext : DbContext
{
    public DbSet<Person> Persons { get; set; } = null!;
    public DbSet<EmploymentType> EmploymentTypes { get; set; } = null!;
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; } = null!;
    public DbSet<Education> Educations { get; set; } = null!;
    public DbSet<MilitaryService> MilitaryServices { get; set; } = null!;
    public DbSet<JobGroup> JobGroups { get; set; } = null!;
    public DbSet<Occupation> Occupations { get; set; } = null!;
    public DbSet<EducationRelationStatus> EducationRelationStatuses { get; set; } = null!;
    public DbSet<ProfessionalPath> ProfessionalPaths { get; set; } = null!;

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
        modelBuilder.Entity<MilitaryService>().HasData(
            new MilitaryService
            {
                Id = 1,
                Description = "پروژه نخبه وظیفه"
            },
            new MilitaryService
            {
                Id = 2,
                Description = "در حال انجام"
            },
            new MilitaryService
            {
                Id = 3,
                Description = "کارت پایان خدمت"
            },
            new MilitaryService
            {
                Id = 4,
                Description = "کارت معافیت "
            },
            new MilitaryService
            {
                Id = 5,
                Description = "معافیت پزشکی"
            },
            new MilitaryService
            {
                Id = 6,
                Description = "معافیت تحصیلی"
            },
            new MilitaryService
            {
                Id = 7,
                Description = "معافیت دائم"
            },
            new MilitaryService
            {
                Id = 8,
                Description = "معافیت زیر پرچم"
            },
            new MilitaryService
            {
                Id = 9,
                Description = "معافیت کفالت"
            },
            new MilitaryService
            {
                Id = 10,
                Description = "معافیت موارد خاص"
            }
        );
        modelBuilder.Entity<JobGroup>().HasData(
            new JobGroup
            {
                Id = 1,
                Description = "1",
                // ProportionIncrease = 1,
                // IncreaseCoefficient = 0,
                // CumulativeCoefficient = 0,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 2,
                Description = "2",
                // ProportionIncrease = 1.02,
                // IncreaseCoefficient = 0.02,
                // CumulativeCoefficient = 0.02,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 3,
                Description = "3",
                // ProportionIncrease = 1.02,
                // IncreaseCoefficient = 0.02,
                // CumulativeCoefficient = 0.04,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 4,
                Description = "4",
                // ProportionIncrease = 1.02,
                // IncreaseCoefficient = 0.02,
                // CumulativeCoefficient = 0.06,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 5,
                Description = "5",
                // ProportionIncrease = 1.02,
                // IncreaseCoefficient = 0.02,
                // CumulativeCoefficient = 0.08,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 6,
                Description = "6",
                // ProportionIncrease = 1.02,
                // IncreaseCoefficient = 0.02,
                // CumulativeCoefficient = 0.1,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 7,
                Description = "7",
                // ProportionIncrease = 1.02,
                // IncreaseCoefficient = 0.02,
                // CumulativeCoefficient = 0.12,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 8,
                Description = "8",
                // ProportionIncrease = 1.02,
                // IncreaseCoefficient = 0.02,
                // CumulativeCoefficient = 0.14,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 9,
                Description = "9",
                // ProportionIncrease = 1.02,
                // IncreaseCoefficient = 0.02,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 10,
                Description = "10",
                // ProportionIncrease = 1.02,
                // IncreaseCoefficient = 0.02,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 11,
                Description = "11",
                // ProportionIncrease = 1.05,
                // IncreaseCoefficient = 0.05,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 12,
                Description = "12",
                // ProportionIncrease = 1.05,
                // IncreaseCoefficient = 0.05,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 13,
                Description = "13",
                // ProportionIncrease = 1.05,
                // IncreaseCoefficient = 0.05,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 14,
                Description = "14",
                // ProportionIncrease = 1.05,
                // IncreaseCoefficient = 0.05,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 15,
                Description = "15",
                // ProportionIncrease = 1.05,
                // IncreaseCoefficient = 0.05,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 16,
                Description = "16",
                // ProportionIncrease = 1.06,
                // IncreaseCoefficient = 0.06,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 17,
                Description = "17",
                // ProportionIncrease = 1.06,
                // IncreaseCoefficient = 0.06,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 18,
                Description = "18",
                // ProportionIncrease = 1.06,
                // IncreaseCoefficient = 0.06,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 19,
                Description = "19",
                // ProportionIncrease = 1.06,
                // IncreaseCoefficient = 0.06,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id =20 ,
                Description = "20",
                // ProportionIncrease = 1.06,
                // IncreaseCoefficient = 0.06,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id =21 ,
                Description = "A",
                // ProportionIncrease = 1.07,
                // IncreaseCoefficient = 0.07,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 22,
                Description = "B",
                // ProportionIncrease = 1.07,
                // IncreaseCoefficient = 0.07,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 23,
                Description = "C",
                // ProportionIncrease = 1.07,
                // IncreaseCoefficient = 0.07,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 24,
                Description = "D",
                // ProportionIncrease = 1.07,
                // IncreaseCoefficient = 0.07,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            },
            new JobGroup
            {
                Id = 25,
                Description = "E",
                // ProportionIncrease = 1.07,
                // IncreaseCoefficient = 0.07,
                // CumulativeCoefficient = ,
                // FinalCoefficient = ,
                // JobExtra = ,
                // ManagementExtra =
            }
        );
        modelBuilder.Entity<Occupation>().HasData(
            new Occupation
            {
                Id = 1,
                Description = "صف تخصصی - فنی",
                Coefficient = 2.8
            },
            new Occupation
            {
                Id = 2,
                Description = "صف تخصصی - فنی 1",
                Coefficient = 2
            },
            new Occupation
            {
                Id = 3,
                Description = "صف تخصصی - فنی 2",
                Coefficient = 1.5
            },
            new Occupation
            {
                Id = 4,
                Description = "صف تخصصی - فنی 3",
                Coefficient = 1.2
            },
            new Occupation
            {
                Id = 5,
                Description = "صف تخصصی - پشتیبانی",
                Coefficient = 2.5
            },
            new Occupation
            {
                Id = 6,
                Description = "صف تخصصی - پشتیبانی 1",
                Coefficient = 1.7
            },
            new Occupation
            {
                Id = 7,
                Description = "صف تخصصی - پشتیبانی 2",
                Coefficient = 1.25
            },
            new Occupation
            {
                Id = 8,
                Description = "صف تخصصی - پشتیبانی 3",
                Coefficient = 1.2
            },
            new Occupation
            {
                Id = 9,
                Description = "ستاد تخصصی",
                Coefficient = 1.1
            },
            new Occupation
            {
                Id = 10,
                Description = "ستاد پشتیبانی",
                Coefficient = 1.05
            },
            new Occupation
            {
                Id = 11,
                Description = "ستاد خدماتی",
                Coefficient = 1
            }
        );
        modelBuilder.Entity<EducationRelationStatus>().HasData(
            new EducationRelationStatus
            {
                Id = 1,
                Description = "مرتبط",
                Coefficient = 1
            },
            new EducationRelationStatus
            {
                Id = 2,
                Description = "نیمه مرتبط",
                Coefficient = 0.85
            },
            new EducationRelationStatus
            {
                Id = 3,
                Description = "غیر مرتبط",
                Coefficient = 0.7
            }
        );
        modelBuilder.Entity<ProfessionalPath>().HasData(
            new ProfessionalPath
            {
                Id = 1,
                Description = "مدیریتی",
                Amount = 33218504,
                Coefficient = 1
            },
            new ProfessionalPath
            {
                Id = 2,
                Description = "کارشناسی",
                Amount = 16609252,
                Coefficient = 0.5
            },
            new ProfessionalPath
            {
                Id = 3,
                Description = "کاردانی",
                Amount = 11072835,
                Coefficient = 0.33
            },
            new ProfessionalPath
            {
                Id = 4,
                Description = "کارمندی",
                Amount = 8304626,
                Coefficient = 0.25
            },
            new ProfessionalPath
            {
                Id = 5,
                Description = "کارگری",
                Amount = 6643701,
                Coefficient = 0.2
            }
        );
    }
}