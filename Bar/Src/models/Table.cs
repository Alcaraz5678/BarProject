using System;

namespace BarProject.Src
{
    public class Table
    {
        private static int nextId = 1;

        public int idTable { get; set; }
        public List<Order> orders { get; set; }
        public double totalTable { get; set; }

        public Table()
        {
            idTable = nextId++;
            orders = new List<Order>();
            totalTable = 0;
        }

        public void ResetTable()
        {
            orders.Clear();
            totalTable = 0;
        }

        public void ViewSummary()
        {
            Console.WriteLine($"Table {idTable} Summary:");
            foreach (Order order in orders)
            {
                Console.WriteLine($"Order ID: {order.idOrder}, Total: {order.totalOrder}");
            }
            Console.WriteLine($"Total Table: {totalTable}");
        }

        public void CalculateTotalTable()
        {
            totalTable = 0;
            foreach (Order order in orders)
            {
                totalTable += order.totalOrder;
            }
        }
    }
}    
//ya esta listo