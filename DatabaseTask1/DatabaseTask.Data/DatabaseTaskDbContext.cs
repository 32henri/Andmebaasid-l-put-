using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.

        public DbSet<Employee> Employee { get; set; }
        public DbSet<ConstructionCompany> ConstructionCompanies { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Specialist> Specialists { get; set; }
    }
}
