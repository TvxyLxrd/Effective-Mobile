using System;
using System.Collections.Generic;
using System.Linq;

namespace DeliveryService
{
    public class DeliveryService
    {
        private List<Order> orders;

        public DeliveryService(List<Order> orders)
        {
            this.orders = orders;
        }

        public List<Order> FilterOrders(string district, DateTime firstDeliveryTime)
        {
            DateTime endTime = firstDeliveryTime.AddMinutes(30);
            return orders.Where(o => o.District.Equals(district, StringComparison.OrdinalIgnoreCase) &&
                                     o.DeliveryTime >= firstDeliveryTime &&
                                     o.DeliveryTime <= endTime).ToList();
        }
    }
}
