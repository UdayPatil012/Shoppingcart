namespace Shoppingcart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "Computer", 50000, 10);
            Product p2 = new Product(2, "Laptop", 60000, 5);
            Product p3 = new Product(3, "Mobile", 20000, 5);
            Product p4 = new Product(4, "Printer", 15000, 2);

            LineItem li1 = new LineItem(1, 2, p1);
            LineItem li2 = new LineItem(2, 1, p2);
            LineItem li3 = new LineItem(3, 1, p3);
            LineItem li4 = new LineItem(4, 2, p4);

            Order or1 = new Order(200, DateTime.Now);
            or1.AddItem(li1);
            or1.AddItem(li2);
            or1.AddItem(li3);
            or1.AddItem(li4);

            Order or2 = new Order(201, DateTime.Now);
            or2.AddItem(li2);
            or2.AddItem(li3);

            Customer customer1 = new Customer(1, "Uday");
            customer1.AddOrder(or1);
            customer1.AddOrder(or2);

            Console.WriteLine("order summary");
            foreach (var item in or1.Items)
            {
                Console.WriteLine($"Product : {item.Product.Name}, Quantity : {item.Quantity}, Price after discount : {item.Product.DiscountedPrice()},Total : {item.ItemCost()} ");
            }
            Console.WriteLine($"Total Order Price : {or1.OrderPrice()}");

            foreach (var item in or2.Items)
            {
                Console.WriteLine($"Product : {item.Product.Name}, Quantity : {item.Quantity}, Price after discount : {item.Product.DiscountedPrice()},Total : {item.ItemCost()} ");
            }
            Console.WriteLine($"Total Order Price : {or2.OrderPrice()}");
        }
    
    }
}
