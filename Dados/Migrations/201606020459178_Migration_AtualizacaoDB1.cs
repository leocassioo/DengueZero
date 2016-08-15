namespace Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_AtualizacaoDB1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        EnderecoID = c.Long(nullable: false, identity: true),
                        Logradouro = c.String(nullable: false, maxLength: 90),
                        Numero = c.Int(),
                        Cep = c.Int(),
                        Bairro = c.String(maxLength: 80),
                        Cidade = c.String(nullable: false, maxLength: 80),
                        Estado = c.String(nullable: false, maxLength: 40),
                        Pais = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.EnderecoID);
            
            CreateTable(
                "dbo.Foco",
                c => new
                    {
                        FocoID = c.Long(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 400),
                        Status = c.Int(nullable: false),
                        Latitude = c.Long(),
                        Longitude = c.Long(),
                        Foto = c.Binary(),
                        PessoaFisica_PessoaID = c.Long(),
                        PessoaJuridica_PessoaID = c.Long(),
                    })
                .PrimaryKey(t => t.FocoID)
                .ForeignKey("dbo.Endereco", t => t.FocoID)
                .ForeignKey("dbo.PessoaFisica", t => t.PessoaFisica_PessoaID)
                .ForeignKey("dbo.PessoaJuridica", t => t.PessoaJuridica_PessoaID)
                .Index(t => t.FocoID)
                .Index(t => t.PessoaFisica_PessoaID)
                .Index(t => t.PessoaJuridica_PessoaID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioID = c.Long(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 30),
                        Senha = c.String(nullable: false, maxLength: 40),
                        RespostaSecreta = c.String(nullable: false, maxLength: 40),
                        Pessoa_PessoaID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioID)
                .Index(t => t.Login, unique: true);
            
            CreateTable(
                "dbo.PessoaEntidadeEnderecoEntidades",
                c => new
                    {
                        PessoaEntidade_PessoaID = c.Long(nullable: false),
                        EnderecoEntidade_EnderecoID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.PessoaEntidade_PessoaID, t.EnderecoEntidade_EnderecoID })
                .ForeignKey("dbo.Endereco", t => t.EnderecoEntidade_EnderecoID, cascadeDelete: true)
                .Index(t => t.EnderecoEntidade_EnderecoID);
            
            CreateTable(
                "dbo.PessoaFisica",
                c => new
                    {
                        PessoaID = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 90),
                        Telefone = c.String(maxLength: 14),
                        Email = c.String(maxLength: 90),
                        CPF = c.String(nullable: false, maxLength: 11),
                        Sexo = c.Int(),
                        DataNascimento = c.DateTime(),
                    })
                .PrimaryKey(t => t.PessoaID);
            
            CreateTable(
                "dbo.PessoaJuridica",
                c => new
                    {
                        PessoaID = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 90),
                        Telefone = c.String(maxLength: 14),
                        Email = c.String(maxLength: 90),
                        CNPJ = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.PessoaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PessoaEntidadeEnderecoEntidades", "EnderecoEntidade_EnderecoID", "dbo.Endereco");
            DropForeignKey("dbo.Foco", "PessoaJuridica_PessoaID", "dbo.PessoaJuridica");
            DropForeignKey("dbo.Foco", "PessoaFisica_PessoaID", "dbo.PessoaFisica");
            DropForeignKey("dbo.Foco", "FocoID", "dbo.Endereco");
            DropIndex("dbo.PessoaEntidadeEnderecoEntidades", new[] { "EnderecoEntidade_EnderecoID" });
            DropIndex("dbo.Usuario", new[] { "Login" });
            DropIndex("dbo.Foco", new[] { "PessoaJuridica_PessoaID" });
            DropIndex("dbo.Foco", new[] { "PessoaFisica_PessoaID" });
            DropIndex("dbo.Foco", new[] { "FocoID" });
            DropTable("dbo.PessoaJuridica");
            DropTable("dbo.PessoaFisica");
            DropTable("dbo.PessoaEntidadeEnderecoEntidades");
            DropTable("dbo.Usuario");
            DropTable("dbo.Foco");
            DropTable("dbo.Endereco");
        }
    }
}
