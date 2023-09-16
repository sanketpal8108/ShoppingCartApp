using CustomerOrderApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(
                101,"Sanket",new List<Order>
                {
                    new Order(201,new List<LineItem>
                    {
                        new LineItem(301,2,new Product(401,"Bread",40,5)),
                        new LineItem(302,4,new Product(402,"Milk",100,10))
                    }),
                    new Order(202,new List<LineItem>
                    {
                        new LineItem(303,1,new Product(403,"Butter",50,1)),
                        new LineItem(304,2,new Product(404,"Paneer",200,20))
                    })
                }
                );
            Console.WriteLine(customer);
        }
    }
}
