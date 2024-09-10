using System;


namespace Bar.src.models
{
    public class Order
    {
        private static int nextId = 1;

        public int idOrder { get; set; }
        public List<Product> orderProducts { get; set; }
        public double totalOrder { get; set; }
        public bool tip { get; set; }
        public double valueTip { get; set; }
        public bool status { get; set; }

        public Order()
        {
            idOrder = nextId++;
            status = false;
            orderProducts = new List<Product>();
        }

        public void CalculateTotal()
        {
            double subtotal = orderProducts.Sum(product => product.Price);
            CheckTip(tip, subtotal);
            totalOrder = subtotal + valueTip;
        }

        public void CheckTip(bool tip, double subtotal)
        {
            if (tip)
            {
                valueTip = subtotal * 0.1;
            }
            else
            {
                valueTip = 0;
            }
        }
    }
}
//ya esta listo