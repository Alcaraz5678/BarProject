using System;
using System.Collections.Generic;
namespace BarProject.Bar.src.models
{
    public class Inventory
    {
        private Dictionary<string, int> inventory = new Dictionary<string, int>();
       
        public void AddProduct(string productName, int quantity)
        {
            if (inventory.ContainsKey(productName))
            {
                inventory[productName] += quantity;
            }
            else
            {
                inventory.Add(productName, quantity);
            }
        }

        public void RemoveProduct(string productName, int quantity)
        {
            if (inventory.ContainsKey(productName))
            {
                inventory[productName] -= quantity;
                if (inventory[productName] <= 0)
                {
                    inventory.Remove(productName);
                }
            }
        }

        public int GetProductQuantity(string productName)
        {
            if (inventory.ContainsKey(productName))
            {
                return inventory[productName];
            }
            else
            {
                return 0;
            }
        }
    }
}
//ya esta listo