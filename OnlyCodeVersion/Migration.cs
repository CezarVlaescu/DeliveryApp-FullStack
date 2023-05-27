using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        using (var dbContext = new FoodOrderingDbContext())
        {
            // Create or update the database schema
            dbContext.Database.Migrate();

            // Seed the data to the database
            SeedData(dbContext);
        }
    }

    private static void SeedData(FoodOrderingDbContext dbContext)
    {
        var restaurant1 = new Restaurant
        {
            Name = "Marty",
            Schedule = "08:00 - 20:00",
            MinimumOrder = 50,
            StandardDeliveryDistance = 15,
            StandardDeliveryPrice = 25,
            ExtraDeliveryFee = 3,
            MenuItems = new List<MenuItem>
                {
                   new MenuItem { Name = "Beef Soup", Description = "A delicious soup", Price = 120 },
                   new MenuItem { Name = "Greek Salad", Description = "Taste our special salad with greek vibes", Price = 25 },
                   new MenuItem { Name = "Cheesecake", Description = "Our special desert", Price = 50 }
                }
        };

        var restaurant2 = new Restaurant
        {
            Name = "KFC",
            Schedule = "09:00 - 21:00",
            MinimumOrder = 35,
            StandardDeliveryDistance = 100,
            StandardDeliveryPrice = 20,
            ExtraDeliveryFee = 0.8m,
            MenuItems = new List<MenuItem>
                {
                   new MenuItem { Name = "American Bucket", Description = "Taste the american dream", Price = 122 },
                   new MenuItem { Name = "Double Booster", Description = "Boost your taste with our sandwich", Price = 18 },
                   new MenuItem { Name = "Smart Menu", Description = "Student friend", Price = 22 }
                }
        };
        dbContext.Restaurants.AddRange(restaurant1, restaurant2);
        dbContext.SaveChanges();
    }
}
