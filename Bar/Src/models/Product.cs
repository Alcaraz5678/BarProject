using System;

namespace BarProject.Src
{
    public class Product
    {
        private static int nextId = 1;

        public int idProduct { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public Product()
        {
            idProduct = nextId++;
        }
    }
}
//ya esta listo