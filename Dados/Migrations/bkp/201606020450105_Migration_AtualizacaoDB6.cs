namespace Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_AtualizacaoDB6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Foco", "Endereco_EnderecoID", "dbo.Endereco");
            DropIndex("dbo.Foco", new[] { "Endereco_EnderecoID" });
            DropColumn("dbo.Foco", "FocoID");
            RenameColumn(table: "dbo.Foco", name: "Endereco_EnderecoID", newName: "FocoID");
            DropPrimaryKey("dbo.Foco");
            AlterColumn("dbo.Foco", "FocoID", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Foco", "FocoID");
            CreateIndex("dbo.Foco", "FocoID");
            AddForeignKey("dbo.Foco", "FocoID", "dbo.Endereco", "EnderecoID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foco", "FocoID", "dbo.Endereco");
            DropIndex("dbo.Foco", new[] { "FocoID" });
            DropPrimaryKey("dbo.Foco");
            AlterColumn("dbo.Foco", "FocoID", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Foco", "FocoID");
            RenameColumn(table: "dbo.Foco", name: "FocoID", newName: "Endereco_EnderecoID");
            AddColumn("dbo.Foco", "FocoID", c => c.Long(nullable: false, identity: true));
            CreateIndex("dbo.Foco", "Endereco_EnderecoID");
            AddForeignKey("dbo.Foco", "Endereco_EnderecoID", "dbo.Endereco", "EnderecoID", cascadeDelete: true);
        }
    }
}
