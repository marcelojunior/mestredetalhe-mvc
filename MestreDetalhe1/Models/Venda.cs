using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MestreDetalhe1.Models
{
    public class Venda
    {
        public long Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }
        
        // Cliente
        public long ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        //Itens
        public virtual List<Item> Itens { get; set; }

        // Método construtor
        public Venda()
        {
            this.Itens = new List<Item>(); // Inicia toda venda com pelo menos um item
        }

        // Método para adicionar itens à venda
        public void AddItem(Item item)
        {
            item.Venda = this;
            Itens.Add(item);
        }
    }
}