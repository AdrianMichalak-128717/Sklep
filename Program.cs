using Sklep;
using System;
using System.Collections.Generic;

class Program
{
    public static void DisplayWelcome()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("--- SKLEP ---");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("1. Wyświetl dostępne produkty");
        Console.WriteLine("2. Wyświetl szczegóły produktu");
        Console.WriteLine("3. Dodaj do koszyka");
        Console.WriteLine("4. Pokaż koszyk");
        Console.WriteLine("5. Wyjście");
        Console.WriteLine();
        Console.Write("Wybierz opcję: ");
    }
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product(1, "Laptop Dell Precision 5480", "Świetny laptop z procesorem i7 i grafiką NVIDIA RTX", 3499),
            new Product(2, "Myszka Logitech G203", "Myszka bezprzewodowa na Bluetooth", 199),
            new Product(3, "Klawiatura Nubi NK87", "Klawiatura mechaniczna z przełącznikami Sapphire", 149),
            new Product(4, "Monitor Dell 24 cale", "Rozdzielczość ekranu 1920x1080", 349),
            new Product(5, "Słuchawki Apple AirPods 4", "Posiadają technologię aktywnego wygłuszania ANC", 699),
            new Product(6, "Pendrive GoodRam 64 GB", "Wersja z połączeniem USB 3.0", 49),
            new Product(7, "Tablet Apple iPad Air", "Wersja pamięciowa 256 GB, kolor czarny", 2899),
            new Product(8, "Smartfon Apple iPhone 15 Pro", "Kolor Dark Blue, pamięć 128 GB", 4199),
            new Product(9, "Podkładka SteelSeries QCK", "Podkładka o rozmiarach 30x40 cm", 79),
            new Product(10, "Aparat Nikon D3500", "Lustrzanka w zestawie z obiektywem 18-55mm", 1499),
        };
        Cart cart = new Cart();
        bool running = true;

        while (running)
        {
            DisplayWelcome();
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    foreach (var product in products)
                    { 
                        if (product.Id == 1)
                        {
                            Console.WriteLine();
                            product.Display();
                        }
                        else if (product.Id == products.Count)
                        {
                            product.Display();
                            Console.WriteLine();
                        }
                        else
                        {
                            product.Display();
                        }
                    }
                    break;
                case "2":
                    Console.Write("Podaj ID produktu: ");
                    int detailsId = int.Parse(Console.ReadLine());
                    foreach (var product in products)
                    {
                        if (product.Id == detailsId)
                        {
                            Console.WriteLine();
                            product.DisplayWithDetails();
                            Console.WriteLine();
                        }
                    }
                    break;
                case "3":
                    Console.Write("Podaj ID produktu: ");
                    int toCartId = int.Parse(Console.ReadLine());
                    if (toCartId <= 0 || toCartId > products.Count)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Nie znaleziono produktu o takim ID!");
                        Console.WriteLine();
                        break;
                    }
                    foreach (var product in products)
                    {
                        if (product.Id == toCartId)
                        {
                            cart.AddProduct(product);
                        }
                    }
                    break;
                case "4":
                    Console.WriteLine();
                    cart.ShowCart();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Niepoprawna opcja!");
                    break;
            }
        }
    }
}
