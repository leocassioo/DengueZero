namespace Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_AtualizacaoDB3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Foco", name: "Endereco_EnderecoID", newName: "EnderecoID");
            RenameIndex(table: "dbo.Foco", name: "IX_Endereco_EnderecoID", newName: "IX_EnderecoID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Foco", name: "IX_EnderecoID", newName: "IX_Endereco_EnderecoID");
            RenameColumn(table: "dbo.Foco", name: "EnderecoID", newName: "Endereco_EnderecoID");
        }
    }
}
