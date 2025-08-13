using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductLINQFullExample
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ManufactureDate { get; set; }

        public Product(int id, string name, double price, DateTime date)
        {
            ID = id;
            Name = name;
            Price = price;
            ManufactureDate = date;
        }
    }
}