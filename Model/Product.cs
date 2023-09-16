using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderApp.Model
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }
        public Product(int id, string name, double price, double discountPercentage)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercentage = discountPercentage;
        }
        public double CalculateDiscountedPrice()
        {
            double discountedPrice =  this.Price - this.Price*(this.DiscountPercentage/100);
            return discountedPrice;
        }

        //public override string ToString()
        //{
        //    return $"{this.Id} {this.Name} {this.Price} {this.DiscountPercentage}% {CalculateDiscountedPrice()}";
        //}
    }
}
