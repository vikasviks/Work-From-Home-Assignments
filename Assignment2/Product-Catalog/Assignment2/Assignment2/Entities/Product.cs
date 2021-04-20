using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Entities
{
    public class Product
    {
        public static int ID = 1;
        public int ProductId { get; set; }
        public static int GenerateProductId()
        {
            return ID++;
        }
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public string ProductShortCode { get; set; }
        public List<Category> ProductCategory { get; set; }
        public Product()
        {
            this.ProductCategory = new List<Category>();
        }
        public string ProductDescription { get; set; }
        public int Selling_Price { get; set; }

    }
}
