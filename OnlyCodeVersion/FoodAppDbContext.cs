using Microsoft.EntityFrameworkCore;

public class FoodOrderingDbContext : DbContext
{
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<CartItem> CartItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlServer("Server=<server_name>;Database=<database_name>;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Restaurant>()
            .HasMany(r => r.MenuItems)
            .WithOne(mi => mi.Restaurant)
            .HasForeignKey(mi => mi.RestaurantId);

        modelBuilder.Entity<Order>()
            .HasMany(o => o.CartItems)
            .WithOne(ci => ci.Order)
            .HasForeignKey(ci => ci.OrderId);

        modelBuilder.Entity<CartItem>()
            .HasOne(ci => ci.MenuItem)
            .WithMany()
            .HasForeignKey(ci => ci.MenuItemId);
    }
}
