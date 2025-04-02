using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string connectionString = @"Server=localhost; Database=HW-03.04; Port=5432; User Id=postgres; Password=Fa1konm1;";
    
        optionsBuilder.UseNpgsql(connectionString);
    }
}