using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Case> Cases { get; set; }
    public DbSet<PersonCase> PersonCases { get; set; }
    public DbSet<PersonType> PersonTypes { get; set; }
    public DbSet<CaseType> CasesTypes { get; set; }
    public DbSet<TaskCase> TaskCases { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

         modelBuilder.Entity<Person>()
        .HasKey(s => s.PersonId);
         modelBuilder.Entity<Case>()
        .HasKey(s => s.CaseId);
         modelBuilder.Entity<TaskCase>()
        .HasKey(s => s.TaskId);
        modelBuilder.Entity<PersonType>()
        .HasKey(s => s.PersonTypeId);
        // Relación muchos a muchos entre Person y Case
        modelBuilder.Entity<PersonCase>()
            .HasKey(pc => new { pc.PersonId, pc.CaseId }); // La clave primaria compuesta

        modelBuilder.Entity<PersonCase>()
            .HasOne(pc => pc.Person)
            .WithMany(p => p.PersonCases)
            .HasForeignKey(pc => pc.PersonId);

        modelBuilder.Entity<PersonCase>()
            .HasOne(pc => pc.Case)
            .WithMany(c => c.PersonCases)
            .HasForeignKey(pc => pc.CaseId);
    }
}
