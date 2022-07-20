using System;
using System.Collections.Generic;
using System.Text;

namespace PENSIONATO_POO
{
    class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante (string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nome}, {Email}.";
        }
    }
}
