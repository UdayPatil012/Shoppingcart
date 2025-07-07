using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Order { get; set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
            Order = new List<Order>();
        }
        public void AddOrder(Order order)
        {
            Order.Add(order);
        }
    }
}
