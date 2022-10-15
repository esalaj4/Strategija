using System;

namespace RPPOON_LV6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("bijela cokolada", 21);
            Product product2 = new Product("tamna cokolada", 21);
            Product product3 = new Product("cokolada od jagode", 21);

            Box box = new Box();
            box.AddProduct(product1);
            box.AddProduct(product2);
            box.AddProduct(product3);

            Iterator iterator = new Iterator(box);

            Console.WriteLine(iterator.First().ToString());
        }
    }
}
