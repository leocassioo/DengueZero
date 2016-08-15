namespace Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_AtualizacaoDB2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Foco", "FocoID", "dbo.Endereco");
            DropIndex("dbo.Foco", new[] { "FocoID" });
            AddColumn("dbo.Foco", "Endereco_EnderecoID", c => c.Long(nullable: false));
            CreateIndex("dbo.Foco", "Endereco_EnderecoID");
            AddForeignKey("dbo.Foco", "Endereco_EnderecoID", "dbo.Endereco", "EnderecoID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foco", "Endereco_EnderecoID", "dbo.Endereco");
            DropIndex("dbo.Foco", new[] { "Endereco_EnderecoID" });
            DropColumn("dbo.Foco", "Endereco_EnderecoID");
            CreateIndex("dbo.Foco", "FocoID");
            AddForeignKey("dbo.Foco", "FocoID", "dbo.Endereco", "EnderecoID");
        }
    }
}
