using System;

namespace BarProject.Bar.src.models
{
    public class Product
    {
        private static int nextId = 1;

        public int IdProduct { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
            IdProduct = nextId++;
        }
    }
}
//ya esta listo