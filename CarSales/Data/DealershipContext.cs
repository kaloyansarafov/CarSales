using Microsoft.EntityFrameworkCore;

namespace CarSales.Data;

public sealed class DealershipContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Server=MSI\\SQLEXPRESS;Database=CarSales;Trusted_Connection=True;TrustServerCertificate=True;")
            .EnableSensitiveDataLogging();
    }
    
    
    public DbSet<Car?> Cars { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<CarSale> CarSales { get; set; }
}