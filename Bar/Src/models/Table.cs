using System;
using System.Collections.Generic;
namespace BarProject.Bar.src.models
{
    public class Table
    {
        private static int nextId = 1;

        public int IdTable { get; set; }
        public List<Order> Orders { get; set; }
        public double TotalTable { get; set; }

        public Table()
        {
            IdTable = nextId++;
            Orders = new List<Order>();
            TotalTable = 0;
        }

        public void ResetTable()
        {
            Orders.Clear();
            TotalTable = 0;
        }

        public void ViewSummary()
        {
            Console.WriteLine($"Table {IdTable} Summary:");
            foreach (Order order in Orders)
            {
                Console.WriteLine($"Order ID: {order.IdOrder}, Total: {order.TotalOrder}");
            }
            Console.WriteLine($"Total Table: {TotalTable}");
        }

        public void CalculateTotalTable()
        {
            TotalTable = 0;
            foreach (Order order in Orders)
            {
                TotalTable += order.TotalOrder;
            }
        }
    }
}    
//ya esta listo