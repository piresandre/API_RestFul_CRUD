using EstudoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EstudoApi.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Clientes> clientes = new List<Clientes>();
        public List<Clientes> Get()
        {
            return clientes;
        }
        [HttpPost]
        public void Post(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                clientes.Add(new Clientes(nome));
            }
        }
        [HttpDelete]
        public void Delete(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                clientes.RemoveAt(clientes.IndexOf(clientes.First(x=> x.Nome.Equals(nome))));
            }
        }
    }
}
