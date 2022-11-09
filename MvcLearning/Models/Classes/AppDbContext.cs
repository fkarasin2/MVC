using Microsoft.EntityFrameworkCore;

namespace MvcLearning.Models.Classes;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("*", (e) => { e.EnableRetryOnFailure(); });
        optionsBuilder.EnableSensitiveDataLogging();
    }

    public DbSet<Admin> Admins { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Currrent> Currrents { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Expenses> Expensies { get; set; }
    public DbSet<FaturaKalem> FaturaKalems { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Personal> Personals { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<SalesMovement> SalesMovements { get; set; }
}