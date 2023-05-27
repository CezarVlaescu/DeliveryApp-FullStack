public class Restaurant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Schedule { get; set; }
    public decimal MinimumOrder { get; set; }
    public int StandardDeliveryDistance { get; set; }
    public decimal StandardDeliveryPrice { get; set; }
    public decimal ExtraDeliveryFee { get; set; }
    public List<MenuItem> MenuItems { get; set; }
}

public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public int DistanceInKm { get; set; }
    public string OrderMentions { get; set; }
    public decimal TotalPrice { get; set; }
    public string OrderCode { get; set; }
    public OrderStatus Status { get; set; }
    public List<CartItem> CartItems { get; set; }
}

public class CartItem
{
    public int Id { get; set; }
    public int MenuItemId { get; set; }
    public MenuItem MenuItem { get; set; }
    public int Quantity { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
}

public enum OrderStatus
{
    Pending,
    Confirmed,
    Completed
}

