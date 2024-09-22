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

        public string ViewSummary()
        {
            return this.ToString();
        }

        public void CalculateTotalTable()
        {
            TotalTable = 0;
            foreach (Order order in Orders)
            {
                TotalTable += order.TotalOrder;
            }
        }

        public override string ToString()
        {
            string result = $"Table {IdTable} Summary:\n";
            
            // Iterar sobre los pedidos
            foreach (Order order in Orders)
            {
                result += $"  Order ID: {order.IdOrder}, Total: ${order.TotalOrder}\n";
            }

            // Agregar el total de la mesa
            result += $"Total Table: ${TotalTable}\n";

            return result;
        }
    }
}    
//ya esta listo