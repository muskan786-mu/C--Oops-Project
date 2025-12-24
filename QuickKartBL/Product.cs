using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace QuickKartBL
{
    public class Product
    {
        private string description;
        private double price;
        private string productId;
        private string productName;
        private int quantityAvailable;

        public string Description { get
            {
                return description;
            } set
            {
                description = value;
            }
        }
        public double Price { get
            {
                return price;
            } set {
                price = 0;
            }
        }
        public string ProductId { get; set; }
        public int QuantityAvailable { get; set;}
        public string ProductName { get
            {
                return productName;
            }
            set
            {
               if(Validator.IsName(value))
                    productName = value;
               else
                    productName = null;
            } }
        public Product(string productId,string productName,double price,string discription,int quantityAvailable)
        {
            Description = description;
            Price = price;
            ProductName = productName;
            ProductId = productId;
            QuantityAvailable = quantityAvailable;
        }

        public string CalculateDiscount(ref int discount,out double minPrice,out double maxPrice)
        {
            string result = "Eligible for dicount";

            if(this.Price <= 500)
            {
                minPrice = 1;
                maxPrice = 500;
                result = "Not eligible for discount";
            }
            else if(this.Price > 500 && this.Price <= 1000)
            {
                minPrice = 501;
                maxPrice = 1000;
                discount = 5;
            }
            else if(this.Price > 1000 && this.Price <= 5000)
            {
                minPrice = 1001;
                maxPrice = 5000;
                discount = 10;
            }
            else if (this.Price > 5000 && this.Price <= 10000)
            {
                discount = 15;
                minPrice = 5001;
                maxPrice = 10000;
            }
            else
            {
                discount = 20;
                minPrice = 10001;
                maxPrice = double.MaxValue;
            }
            return result;
        }
    }
}
