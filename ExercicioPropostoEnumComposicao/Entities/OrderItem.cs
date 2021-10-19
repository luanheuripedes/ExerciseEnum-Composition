using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoEnumComposicao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Produc { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Produc = product;
        }

        public double subTotal()
        {
            return this.Quantity * this.Price;
        }
    }
}
