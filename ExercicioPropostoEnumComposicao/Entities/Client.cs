﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoEnumComposicao.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }


        public Client()
        {

        }

        public Client(string name, string email, DateTime birthDate)
        {
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }
    }
}
