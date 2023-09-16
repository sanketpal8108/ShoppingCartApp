using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderApp.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public Customer(int id , string name , List<Order> order)
        {
            Id = id;
            Name = name;
            //Orders = new List<Order>
            //{
            //    new Order(101),
            //    new Order(102)
            //};
            Orders = order;
        }
        public string OrderData()
        {
            string data = "";
            foreach (Order order in Orders)
            {
                data += order.ToString();
            }
            return data;
        }
        public override string ToString()
        {
            return $"Customer Id : {this.Id}\n" +
                $"Customer Name : {this.Name}\n" +
                $"Order Count : {Orders.Count}\n" +
                $"{OrderData()}";
        }
    }
}
