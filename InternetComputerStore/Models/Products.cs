using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetComputerStore.Models
{
    public class Products
    {
        public int ProductId { get; set; } // The product ID, primary key, autoincrement
        public string Title { get; set; } //Product title
        public string ShortDescription { get; set; } //A short description that will go to the HTML meta tag

        public decimal Price { get; set; } // Product price 
        public Category Category { get; set; }

    }

    public class Category
    { 
    public int CategoryId { get; set; }
        public string Name { get; set; }

    }
}