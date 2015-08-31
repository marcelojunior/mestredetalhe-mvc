using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MestreDetalhe1.Models
{
    public class Item
    {
        public long Id { get; set; }
        public double Quantidade { get; set; }

        // Produto
        public long ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }

        // Venda
        public long VendaId { get; set; }
        public virtual Venda Venda { get; set; }
    }
}