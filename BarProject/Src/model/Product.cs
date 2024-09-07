using System;

namespace BarProject.Src
{
    public class Product
    {
        public int idProduct { get; set; }
        public string name { get; set; }
        public required double price { get; set; }
    }
}