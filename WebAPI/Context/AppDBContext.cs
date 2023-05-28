using FoodDeliveryAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryAppAPI.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options) 
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Restaurant>().ToTable("restaurant");
        }
    }
}
