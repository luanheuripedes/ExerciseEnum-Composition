using System;
using System.Collections.Generic;
using System.Text;
using ExercicioPropostoEnumComposicao.Enums;

namespace ExercicioPropostoEnumComposicao.Entities
{
    class Order
    {
        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime momment, OrderStatus status)
        {
            Momment = momment;
            Status = status;
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
    }
}
