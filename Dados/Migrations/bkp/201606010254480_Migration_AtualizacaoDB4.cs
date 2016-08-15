namespace Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_AtualizacaoDB4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Endereco", "Bairro", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Endereco", "Estado", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Endereco", "Estado", c => c.String(maxLength: 40));
            AlterColumn("dbo.Endereco", "Bairro", c => c.String(maxLength: 80));
        }
    }
}
