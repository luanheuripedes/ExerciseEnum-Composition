using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoEnumComposicao.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public Product()
        {

        }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
