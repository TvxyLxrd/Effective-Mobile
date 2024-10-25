using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DeliveryService
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 4)
            {
                Console.WriteLine("Usage: DeliveryService <District> <FirstDeliveryTime> <LogFilePath> <ResultFilePath>");
                return;
            }

            string district = args[0];
            DateTime firstDeliveryTime;

            if (!DateTime.TryParse(args[1], out firstDeliveryTime))
            {
                Console.WriteLine("Invalid date format. Use yyyy-MM-dd HH:mm:ss.");
                return;
            }

            string logFilePath = args[2];
            string resultFilePath = args[3];

            Logger logger = new Logger(logFilePath);
            logger.Log("Application started.");

            var orders = LoadOrders("orders.csv");
            DeliveryService deliveryService = new DeliveryService(orders);
            var filteredOrders = deliveryService.FilterOrders(district, firstDeliveryTime);

            using (StreamWriter sw = new StreamWriter(resultFilePath))
            {
                foreach (var order in filteredOrders)
                {
                    sw.WriteLine($"{order.OrderId}, {order.Weight}, {order.District}, {order.DeliveryTime}");
                }
            }

            logger.Log("Filtering completed.");
        }

        public static List<Order> LoadOrders(string filePath)
        {
            var orders = new List<Order>();
            foreach (var line in File.ReadLines(filePath))
            {
                var parts = line.Split(',');
                orders.Add(new Order
                {
                    OrderId = parts[0],
                    Weight = double.Parse(parts[1]),
                    District = parts[2],
                    DeliveryTime = DateTime.Parse(parts[3])
                });
            }
            return orders;
        }
    }
}
