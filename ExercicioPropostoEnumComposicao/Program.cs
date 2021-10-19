using System;
using ExercicioPropostoEnumComposicao.Entities;
using ExercicioPropostoEnumComposicao.Enums;
using System.Globalization;

namespace ExercicioPropostoEnumComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client c1 = new Client(name, email, date);

            // Order
            Console.WriteLine("Enter order data: ");
            Console.WriteLine("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, os, c1);

            //Items
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<= n; i++)
            {
                Console.WriteLine("Enter #" + i + "item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product p = new Product(nameProduct, priceProduct);


                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());


                OrderItem oi = new OrderItem(qtd, priceProduct, p);

                order.AddItem(oi);
            }

            Console.WriteLine(order.ToString());
        }
    }
}
