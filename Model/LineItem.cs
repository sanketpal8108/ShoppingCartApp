using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderApp.Model
{
    internal class LineItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public LineItem(int id ,int quantity, Product product)
        {
            Id = id;
            Quantity = quantity;
            Product = product;
            
        }
        public double CalculateLineItemCost()
        {
            return Quantity*Product.CalculateDiscountedPrice();
        }
        public override string ToString()
        {
            return $"\nLineItemId\tProductId\tProductName\tQuantity\tUnitPrice\tDiscount\tCostAfterDiscount\tTotalLineItemCost" +
                $"\n{this.Id}\t\t {this.Product.Id}\t\t{this.Product.Name}\t\t{this.Quantity}\t\t{this.Product.Price}\t\t" +
                $"{this.Product.DiscountPercentage}%\t\t{this.Product.CalculateDiscountedPrice()}\t\t\t {CalculateLineItemCost()}";
        }
    }
}
