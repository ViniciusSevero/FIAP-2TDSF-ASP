using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.MVC.Models
{
    public class Cerveja
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public decimal Preco { get; set; }
        public bool SemAlcool { get; set; }
        public string Tipo { get; set; }
        public DateTime Validade { get; set; }
    }
}