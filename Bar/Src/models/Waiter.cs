using System;
using System.Collections.Generic;

namespace Bar.src.models
{
    public class Waiter
    {
        private static int _nextId = 1;
        public int IdWaiter { get; private set; }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Name { get; set; }
        public List<Order> OrdersPlaced { get; set; } = new List<Order>();
        public float TotalValueTips { get; private set; }
        public int TotalTips { get; private set; }
        public int TotalCustomers { get; private set; }
        public int WaiterEffectiveness { get; private set; }

        public Waiter(string name, string password)
        {
            IdWaiter = _nextId++;
            Name = name;
            Password = password;
        }

        public Order GenerateOrder(OrderManager orderManager)
        {
            var order = orderManager.GenerateOrder();
            OrdersPlaced.Add(order);
            return order;
        }

        public void PayOrder(Order order, float tip)
        {
            order.IsPaid = true;
            order.Tip = tip;
            UpdateWaiter();
        }

        public void UpdateWaiter()
        {
            TotalValueTips = 0;
            TotalTips = 0;
            TotalCustomers = OrdersPlaced.Count;

            foreach (var order in OrdersPlaced)
            {
                if (order.IsPaid)
                {
                    TotalValueTips += (float)order.Tip;
                    TotalTips++;
                }
            }

            WaiterEffectiveness = TotalCustomers > 0 ? (int)((TotalTips / (float)TotalCustomers) * 100) : 0;
        }
    }
}    