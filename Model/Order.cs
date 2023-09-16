using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderApp.Model
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<LineItem> Items { get; set; }
        public static int InitialOrder = 1;
        private int OrderNO { get; set; }
        public Order(int id, List<LineItem> item  )
        {
            Id = id;
            Date = DateTime.Now;
            //Items = new List<LineItem>
            //{
            //    new LineItem(801,2,new Product(901,"Britania", 50 , 10)),
            //    new LineItem(802,3,new Product(902,"DairyMilk", 100 , 20))
            //};
            Items = item;
            OrderNO = InitialOrder++;
        }
        public double CalculateOrderPrice()
        {
            double orderPrice = 0;
            foreach (LineItem item in Items)
            {
                orderPrice += item.CalculateLineItemCost();
            }
            return orderPrice;
        }
        public string LineItemData()
        {
            string data = "";
            foreach (LineItem item in Items)
            {
                data += item.ToString();
            }
            return data;
        }
        public override string ToString()
        {
            return $"Order No : {this.OrderNO}\n" +
                $"Order Id :{this.Id}\n" +
                $"Order Date : {this.Date}\n" +
                $"{this.LineItemData()}\n" +
                $"\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOrder Cost : {CalculateOrderPrice()}\n" ;
        }
    }
}
