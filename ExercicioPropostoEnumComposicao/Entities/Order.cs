using System;
using System.Collections.Generic;
using System.Text;
using ExercicioPropostoEnumComposicao.Enums;
using ExercicioPropostoEnumComposicao.Entities;
using System.Globalization;

namespace ExercicioPropostoEnumComposicao.Entities
{
    class Order
    {
        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime momment, OrderStatus status, Client client)
        {
            Momment = momment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            this.Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            this.Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;

            foreach (OrderItem item in this.Items)
            {
                total += item.Price;
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine("Order moment: " + Momment);
            sb.AppendLine("Order status" + Status);
            sb.AppendLine("Client: " + Client.Name + " - " + Client.Email);

            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.Produc.Name + item.Produc.Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + item.Quantity + "Subtotal: $" + item.subTotal().ToString("F2", CultureInfo.InvariantCulture));
            }

            sb.AppendLine(Convert.ToString(Total().ToString("F2", CultureInfo.InvariantCulture)));


            return sb.ToString();
        }
    }
}
