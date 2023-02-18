using Microsoft.EntityFrameworkCore;
using Salary34000.Models;

namespace Salary34000.Data;

public class SalaryContext : DbContext
{
    public DbSet<Person> Persons { get; set; } = null!;
    public DbSet<EmploymentType> EmploymentTypes { get; set; } = null!;

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
    }
}