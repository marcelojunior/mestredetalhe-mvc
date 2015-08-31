using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MestreDetalhe1.Models
{
    public class Produto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public double Estoque { get; set; }
    }
}