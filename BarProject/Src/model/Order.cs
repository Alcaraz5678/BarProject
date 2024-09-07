using System;


namespace BarProject.Src
{

    public class Order
    {
        public int idOrder { get; set; }
        public List<Product> orderProducts { get; set; }
        public double totalOrder { get; set; }
        public bool tip { get; set; }
        public double valueTip { get; set; }
        public bool status { get; set; }

        public Order()
        {

            status = false;
            orderProducts = new List<Product>();

        }

        public void CalculateTotal
        {
            //Implementar
        }

        public void CheckTip(bool tip)
        {
            //Implementar
        }
    }
}