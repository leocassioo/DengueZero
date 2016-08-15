namespace Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_AtualizacaoDB3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Usuario", new[] { "Login" });
            DropPrimaryKey("dbo.PessoaFisica");
            DropPrimaryKey("dbo.PessoaJuridica");
            AlterColumn("dbo.Endereco", "Logradouro", c => c.String(nullable: false, maxLength: 90));
            AlterColumn("dbo.Endereco", "Numero", c => c.Int());
            AlterColumn("dbo.Endereco", "Cep", c => c.Int());
            AlterColumn("dbo.Endereco", "Cidade", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Endereco", "Pais", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.PessoaFisica", "PessoaID", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.PessoaFisica", "Nome", c => c.String(nullable: false, maxLength: 90));
            AlterColumn("dbo.PessoaFisica", "CPF", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.PessoaFisica", "Sexo", c => c.Int());
            AlterColumn("dbo.PessoaFisica", "DataNascimento", c => c.DateTime());
            AlterColumn("dbo.PessoaJuridica", "PessoaID", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.PessoaJuridica", "Nome", c => c.String(nullable: false, maxLength: 90));
            AlterColumn("dbo.PessoaJuridica", "CNPJ", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Usuario", "Login", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Usuario", "Senha", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Usuario", "RespostaSecreta", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Usuario", "Pessoa_PessoaID", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.PessoaFisica", "PessoaID");
            AddPrimaryKey("dbo.PessoaJuridica", "PessoaID");
            CreateIndex("dbo.Usuario", "Login", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuario", new[] { "Login" });
            DropPrimaryKey("dbo.PessoaJuridica");
            DropPrimaryKey("dbo.PessoaFisica");
            AlterColumn("dbo.Usuario", "Pessoa_PessoaID", c => c.Long());
            AlterColumn("dbo.Usuario", "RespostaSecreta", c => c.String(maxLength: 40));
            AlterColumn("dbo.Usuario", "Senha", c => c.String(maxLength: 40));
            AlterColumn("dbo.Usuario", "Login", c => c.String(maxLength: 30));
            AlterColumn("dbo.PessoaJuridica", "CNPJ", c => c.String(maxLength: 20));
            AlterColumn("dbo.PessoaJuridica", "Nome", c => c.String(maxLength: 90));
            AlterColumn("dbo.PessoaJuridica", "PessoaID", c => c.Long(nullable: false));
            AlterColumn("dbo.PessoaFisica", "DataNascimento", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PessoaFisica", "Sexo", c => c.Int(nullable: false));
            AlterColumn("dbo.PessoaFisica", "CPF", c => c.String(maxLength: 11));
            AlterColumn("dbo.PessoaFisica", "Nome", c => c.String(maxLength: 90));
            AlterColumn("dbo.PessoaFisica", "PessoaID", c => c.Long(nullable: false));
            AlterColumn("dbo.Endereco", "Pais", c => c.String(maxLength: 40));
            AlterColumn("dbo.Endereco", "Cidade", c => c.String(maxLength: 80));
            AlterColumn("dbo.Endereco", "Cep", c => c.Int(nullable: false));
            AlterColumn("dbo.Endereco", "Numero", c => c.Int(nullable: false));
            AlterColumn("dbo.Endereco", "Logradouro", c => c.String(maxLength: 90));
            AddPrimaryKey("dbo.PessoaJuridica", "PessoaID");
            AddPrimaryKey("dbo.PessoaFisica", "PessoaID");
            CreateIndex("dbo.Usuario", "Login", unique: true);
        }
    }
}
