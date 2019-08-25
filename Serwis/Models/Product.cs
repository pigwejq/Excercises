using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Serwis.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        static int Counter = 0;

        public Product(string Name, string Description, decimal Price, string Category)
        {
            ProductID = Counter++;
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
            this.Category = Category;
        }
    }
}

