namespace Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_AtualizacaoDB1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        PessoaID = c.Long(nullable: false, identity: true),
                        Nome = c.String(maxLength: 90),
                        Telefone = c.String(maxLength: 14),
                        Email = c.String(maxLength: 90),
                    })
                .PrimaryKey(t => t.PessoaID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioID = c.Long(nullable: false, identity: true),
                        Login = c.String(maxLength: 30),
                        Senha = c.String(maxLength: 40),
                        RespostaSecreta = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.UsuarioID)
                .Index(t => t.Login, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuario", new[] { "Login" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Pessoa");
        }
    }
}
