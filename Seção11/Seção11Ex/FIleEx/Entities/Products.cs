using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIleEx.Entities
{
    public class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Products(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total()
        {
            return Price * Quantity;
        }
    }
}