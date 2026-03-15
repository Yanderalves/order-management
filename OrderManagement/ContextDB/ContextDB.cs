using Microsoft.EntityFrameworkCore;
using OrderManagement.Entities;

namespace OrderManagement.ContextDB;


public class ContextDb : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=ordermanagement.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Customer
        modelBuilder.Entity<Customer>().Property(x => x.Name).IsRequired().HasMaxLength(255);
        modelBuilder.Entity<Customer>().HasIndex(x => x.Email).IsUnique();
        modelBuilder.Entity<Customer>().Property(x => x.Email).IsRequired().HasMaxLength(255);
        modelBuilder.Entity<Customer>().HasIndex(x => x.Phone).IsUnique();
        modelBuilder.Entity<Customer>().Property(x => x.Phone).IsRequired(false).HasMaxLength(20);
        
        // Order
        modelBuilder.Entity<Order>().HasOne(x => x.Customer).WithMany().HasForeignKey(x => x.CustomerId);
        modelBuilder.Entity<Order>().OwnsOne(x => x.DeliveryAddress, address =>
        {
            address.Property(a => a.Street).IsRequired();
            address.Property(a => a.Number).IsRequired();
            address.Property(a => a.Complement).IsRequired(false); // nullable
            address.Property(a => a.City).IsRequired();
            address.Property(a => a.State).IsRequired();
            address.Property(a => a.ZipCode).IsRequired();
        });        
        // OrderItem
        modelBuilder.Entity<OrderItem>().HasOne(x => x.Order).WithMany().HasForeignKey(x => x.OrderId);
        modelBuilder.Entity<OrderItem>().Property(x => x.TotalPrice).HasColumnType("decimal(18,2)");
        modelBuilder.Entity<OrderItem>().Property(x => x.UnitPrice).HasColumnType("decimal(18,2)");
        

    }
}