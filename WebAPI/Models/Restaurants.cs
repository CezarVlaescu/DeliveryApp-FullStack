namespace FoodDeliveryAppAPI.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int openingTime { get; set; }
        public int closedTime { get; set; }
        public int maxDeliveryDistance { get; set; }
        public int maxFeeDelivery { get; set;}
        public bool extraFee { get; set;}

    }
}
