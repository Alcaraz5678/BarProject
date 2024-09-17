using System;
using System.Collections.Generic;
using System.Linq;


namespace BarProject.Bar.src.models
{
    public class Order
    {
        private static int nextId = 1;

        public int IdOrder { get; set; }
        public List<Product> OrderProducts { get; set; }
        public double TotalOrder { get; set; }
        public bool Tip { get; set; }
        public double ValueTip { get; set; }
        public bool Status { get; set; }

        public Order()
        {
            IdOrder = nextId++;
            Status = false;
            OrderProducts = new List<Product>();
        }

        public void CalculateTotal()
        {
            double subtotal = OrderProducts.Sum(product => product.Price);
            CheckTip(Tip, subtotal);
            TotalOrder = subtotal + ValueTip;
        }

        public void CheckTip(bool Tip, double subtotal)
        {
            if (Tip)
            {
                ValueTip = subtotal * 0.1;
            }
            else
            {
                ValueTip = 0;
            }
        }
    }
}
//ya esta listo