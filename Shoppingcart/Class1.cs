using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercent { get; set; }

        public Product(int id, string name, double price, double discountProdeuct)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercent = discountProdeuct;
        }
        public double DiscountedPrice()
        {
            return Price - (Price * DiscountPercent / 100);
        }

    }
}
