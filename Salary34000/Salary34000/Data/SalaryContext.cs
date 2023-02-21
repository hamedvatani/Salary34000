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
    public DbSet<ExperienceScore> ExperienceScores { get; set; } = null!;
    public DbSet<Performance> Performances { get; set; } = null!;
    public DbSet<PersonalGroup> PersonalGroups { get; set; } = null!;
    public DbSet<Parameter> Parameters { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"DataSource=salary34000.db;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var iType = typeof(IHasInitialData);
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => iType.IsAssignableFrom(p) && p.Name != iType.Name).ToList();
        foreach (var type in types)
            if (Activator.CreateInstance(type) is IHasInitialData obj)
            {
                Array arr = obj.GetInitialData();
                foreach (var item in arr)
                    modelBuilder.Entity(type).HasData(item);
            }
    }
}