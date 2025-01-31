using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Person> Person { get; set; }
    public DbSet<Case> Case { get; set; }
    /*     public DbSet<PersonCase> PersonCases { get; set; }
     */
    public DbSet<PersonType> PersonType { get; set; }
    public DbSet<CasesType> CasesType { get; set; }
    public DbSet<TaskCase> TaskCase { get; set; }
    public DbSet<Client> Client { get; set; }

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
        modelBuilder.Entity<Client>()
              .HasKey(s => s.ClientId);
        modelBuilder.Entity<CasesType>()
      .HasKey(s => s.CaseTypeId);
        /*  // Relación muchos a muchos entre Person y Case
         modelBuilder.Entity<PersonCase>()
             .HasKey(pc => new { pc.PersonId, pc.CaseId }); // La clave primaria compuesta

         modelBuilder.Entity<PersonCase>()
             .HasOne(pc => pc.Person)
             .WithMany(p => p.PersonCases)
             .HasForeignKey(pc => pc.PersonId);

         modelBuilder.Entity<PersonCase>()
             .HasOne(pc => pc.Case)
             .WithMany(c => c.PersonCases)
             .HasForeignKey(pc => pc.CaseId); */
    }
}
