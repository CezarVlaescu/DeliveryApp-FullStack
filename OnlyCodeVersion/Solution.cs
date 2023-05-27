using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace App
{
    class Application
    {
        static void Main(string[] args)
        {
            FoodAppMainClass app = new FoodAppMainClass();

            // Create a few restaurants
            Restaurant restaurant1 = new Restaurant
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

            Restaurant restaurant2 = new Restaurant
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

            app.AddRestaurant(restaurant1);
            app.AddRestaurant(restaurant2);
            Console.WriteLine("Our active restaurants are : ");
            foreach(var restaurant in app.Restaurants)
            {
                Console.WriteLine(restaurant.Name);
            }
            Console.WriteLine("Enter the name of the restaurant: ");
            string selected = Console.ReadLine();
            Restaurant selectedRestaurant = app.Restaurants.Find(r => r.Name == selected);
            if(selectedRestaurant == null)
            {
                Console.WriteLine("Please give a valid name");
                return;
            }
            Console.WriteLine("Menu : ");
            foreach (var menuItem in selectedRestaurant.MenuItems)
            {
                Console.WriteLine($"{menuItem.Name} - {menuItem.Description} - Price: {menuItem.Price}");
            }
            Order order = new Order
            {
                RestaurantName = selectedRestaurant.Name,
                CartItems = new List<CartItem>(),
                Name = string.Empty,
                Address = string.Empty,
                DistanceKm = 0,
                OrderMentions = string.Empty
            };

            Console.Write("Enter your name: ");
            order.Name = Console.ReadLine();

            Console.Write("Enter your address: ");
            order.Address = Console.ReadLine();

            Console.Write("Enter the distance in km: ");
            int distance;
            if (int.TryParse(Console.ReadLine(), out distance))
            {
                order.DistanceKm = distance;
            }
            else
            {
                Console.WriteLine("Invalid distance");
                return;
            }

            Console.Write("Enter any order mentions (optional): ");
            order.OrderMentions = Console.ReadLine();

            Console.WriteLine("Add items to your cart (enter 'done' to finish):");
            while (true)
            {
                Console.Write("Enter the name of the item: ");
                string itemName = Console.ReadLine();

                if (itemName.ToLower() == "done")
                {
                    break;
                }

                MenuItem selectedItem = selectedRestaurant.MenuItems.Find(item => item.Name == itemName);
                if (selectedItem == null)
                {
                    Console.WriteLine("Item name is not valid");
                    continue;
                }

                Console.Write("Enter quantity: ");
                int quantity;
                if (int.TryParse(Console.ReadLine(), out quantity))
                {
                    order.CartItems.Add(new CartItem { MenuItem = selectedItem, Quantity = quantity });
                }
                else
                {
                    Console.WriteLine("Quantity not matched");
                    continue;
                }
            }
            app.PlaceOrder(order);

            Console.Write("Enter your unique code: ");
            string orderCode = Console.ReadLine();
            app.CheckOrderStatus(orderCode);
        }
    }

    public class Restaurant
    {
        public string Name { get; set; }
        public string Schedule { get; set; }
        public decimal MinimumOrder { get; set; }
        public int StandardDeliveryDistance { get; set; }
        public decimal StandardDeliveryPrice { get; set; }
        public decimal ExtraDeliveryFee { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public bool isOpen()
        {
            return true;
        }
    }

    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    } 
    public enum OrderStatus { Pending, Confirmed, Completed }
    public class Order
    {
        public string RestaurantName { get; set; }
        public List<CartItem> CartItems { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int DistanceKm { get; set; }
        public string OrderMentions { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderCode { get; set; }
        public OrderStatus Status { get; set; }
    }

    public class CartItem
    {
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }
    }

    public class FoodAppMainClass
    {
        public List<Restaurant> Restaurants;
        private List<Order> Orders;
        private int orderCodes;

        public FoodAppMainClass()
        {
            Restaurants = new List<Restaurant>();
            Orders = new List<Order>();
            orderCodes = 1;
        }
        public void AddRestaurant(Restaurant restaurant)
        {
            Restaurants.Add(restaurant);
        }

        public void PlaceOrder(Order order)
        {
            decimal totalPrice = CalculateTotalPrice(order);
            Restaurant restaurant = Restaurants.Find(r => r.Name == order.RestaurantName);
            if(restaurant == null || !restaurant.isOpen())
            {
                Console.WriteLine("Restaurant is not available at this time");
                return;
            }
            if(totalPrice < restaurant.MinimumOrder)
            {
                Console.WriteLine($". Total price should be at least {restaurant.MinimumOrder}");
                return;
            }
            decimal deliveryFee = CalculateDeliveryFee(order, restaurant);
            decimal finalTotalPrice = totalPrice + deliveryFee;
            string orderCode = GenerateOrderCode();

            order.TotalPrice = finalTotalPrice;
            order.OrderCode = orderCode;
            order.Status = OrderStatus.Confirmed;

            Orders.Add(order);
            Console.WriteLine($"Order placed successfully. Your order code is: {orderCode}");
        }

        public void CheckOrderStatus(string orderCode)
        {
            Order order = Orders.Find(p => p.OrderCode == orderCode);
            if (order == null) { Console.WriteLine("No order code valid"); return; }
            Console.WriteLine($"Order Details - Order Code: {order.OrderCode}");
            Console.WriteLine($"Restaurant: {order.RestaurantName}");
            Console.WriteLine("Items:");
            foreach(var item in order.CartItems)
            {
                Console.WriteLine($"{item.MenuItem.Name} - Quantity: {item.Quantity}");
            }
            Console.WriteLine($"Total Price: {order.TotalPrice}");
            Console.WriteLine($"Status: {order.Status}");
        }

        private decimal CalculateTotalPrice(Order order)
        {
            decimal totalPrice = 0;
            foreach(var item in order.CartItems)
            {
                totalPrice += item.MenuItem.Price * item.Quantity;
            }
            return totalPrice;
        }
        private decimal CalculateDeliveryFee(Order order, Restaurant restaurant)
        {
            int distance = order.DistanceKm;
            int standardDistance = restaurant.StandardDeliveryDistance;
            decimal standardPrice = restaurant.StandardDeliveryPrice;
            decimal extraFee = restaurant.ExtraDeliveryFee;

            if(distance < standardDistance)
            {
                return standardPrice;
            }
            else
            {
                int extraDistance = distance - standardDistance;
                decimal extraPrice = extraDistance * extraFee;
                return standardPrice + extraPrice;
            }
        }

        private string GenerateOrderCode()
        {
            string code = "ORD" + orderCodes.ToString("D4");
            orderCodes++;
            return code;
        }
    }


