using System;

namespace DeliveryService
{
    public class Order
    {
        public required string OrderId { get; set; }
        public float Weight { get; set; }
        public required string District { get; set; }
        public DateTime DeliveryTime { get; set; }
    }
}
