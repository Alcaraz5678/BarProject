using System;


namespace BarProject.Src
{
    public class Waiter
    {
        public int idWaiter { get; set; }
        private string _password {get; set;}

        public string password 
        {
            get{ return _password; } 
            set { _password = value; }  
        }
        public string nameWaiter {get; set;}
        public List<Order> ordersPlaced { get; set; }
        public double totalValueTips { get; set; }
        public int totalTips { get; set; }
        public int totalCustomers { get; set; }
        public int waiterEffectiveness { get; set; }


        public void UpdateWaiter
        {
            //Implementar
        }

         public void GenerateOrder
        {
            //Implementar
        }

         public void PayOrder
        {
            //Implementar
        }
    }
}    