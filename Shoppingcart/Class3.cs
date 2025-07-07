using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<LineItem> Items { get; set; }

        public Order(int id, DateTime date)
        {
            Id = id;
            Date = date;
            Items = new List<LineItem>();
        }

        public void AddItem(LineItem item)
        {
            Items.Add(item);
        }

        public double OrderPrice()
        {
            double total = 0;
            foreach (LineItem item in Items)
            {
                total = total + item.ItemCost();
            }
            return total;
        }
    }
}
