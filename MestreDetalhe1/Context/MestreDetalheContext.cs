using MestreDetalhe1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MestreDetalhe1.Context
{
    public class MestreDetalheContext : DbContext
    {
        public MestreDetalheContext() : base("MestreDetalhe1Context")
        {
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


        // DbSets
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Item> Itens { get; set; }
    }
}