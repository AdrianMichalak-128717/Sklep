using System;
using System.Collections.Generic;
using System.Text;

namespace Sklep
{
    public class Cart
    {
        private List<Product> items = new List<Product>();

        public void AddProduct(Product product)
        {
            items.Add(product);
            Console.WriteLine();
            Console.WriteLine("Produkt dodany do koszyka.");
            Console.WriteLine();
        }

        public void ShowCart()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Koszyk jest pusty!");
                Console.WriteLine();
                return;
            }

            decimal total = 0;

            Console.WriteLine("Produkty w koszyku:");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} - {item.Price} zł");
                total = total + item.Price;
            }
            Console.WriteLine($"Suma: {total} zł");
            Console.WriteLine();
        }
    }
}
