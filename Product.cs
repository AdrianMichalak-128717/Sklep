using System;
using System.Collections.Generic;
using System.Text;

namespace Sklep
{
    public class Product
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, string description, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"{Id}. {Name} - {Price} zł");
        }

        public void DisplayWithDetails()
        {
            Console.WriteLine($"{Id}. {Name}");
            Console.WriteLine($"{Description}");
            Console.WriteLine($"Cena: {Price} zł");
        }
    }
}
