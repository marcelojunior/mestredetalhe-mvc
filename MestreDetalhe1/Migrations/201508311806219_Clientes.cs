namespace MestreDetalhe1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Clientes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        ClienteId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        Quantidade = c.Double(nullable: false),
                        ProdutoId = c.Long(nullable: false),
                        VendaId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Produto", t => t.ProdutoId, cascadeDelete: true)
                .ForeignKey("dbo.Venda", t => t.VendaId, cascadeDelete: true)
                .Index(t => t.ProdutoId)
                .Index(t => t.VendaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "VendaId", "dbo.Venda");
            DropForeignKey("dbo.Item", "ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.Venda", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Item", new[] { "VendaId" });
            DropIndex("dbo.Item", new[] { "ProdutoId" });
            DropIndex("dbo.Venda", new[] { "ClienteId" });
            DropTable("dbo.Item");
            DropTable("dbo.Venda");
            DropTable("dbo.Cliente");
        }
    }
}
