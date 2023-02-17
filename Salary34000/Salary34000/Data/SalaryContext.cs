using Microsoft.EntityFrameworkCore;
using Salary34000.Models;

namespace Salary34000.Data;

public class SalaryContext : DbContext
{
    public DbSet<Person> Persons { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"DataSource=salary34000.db;");
    }
}