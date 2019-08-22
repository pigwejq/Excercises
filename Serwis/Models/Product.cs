using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Serwis.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public Product Related { get; set; }

        public Product(string Name, decimal? Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        public static Product[] GetProducts()
        {
            Product kayak = new Product("Kajak", 275M);
            Product lifejacket = new Product("Kamizelka ratunkowa", 48.95M);
            kayak.Related = lifejacket;
            return new Product[] { kayak, lifejacket, null };
        }
    }
}

