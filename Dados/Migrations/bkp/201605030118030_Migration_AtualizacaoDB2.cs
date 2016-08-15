namespace Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_AtualizacaoDB2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuario", "Pessoa_PessoaID", c => c.Long());
            CreateIndex("dbo.Usuario", "Pessoa_PessoaID");
            AddForeignKey("dbo.Usuario", "Pessoa_PessoaID", "dbo.Pessoa", "PessoaID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "Pessoa_PessoaID", "dbo.Pessoa");
            DropIndex("dbo.Usuario", new[] { "Pessoa_PessoaID" });
            DropColumn("dbo.Usuario", "Pessoa_PessoaID");
        }
    }
}
