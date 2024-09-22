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

        public override string ToString()
        {
            return $"Id: {IdProduct}, Name: {Name}, Price: {Price}";
        }
    }
}
//ya esta listo