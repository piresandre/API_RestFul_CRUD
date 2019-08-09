using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudoApi.Models
{
    public class Clientes
    {
        public string Nome { get; set; }

        public Clientes(string texto)
        {
            this.Nome = texto;
        }
    }
}