namespace Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_AtualizacaoDB5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Endereco", "Bairro", c => c.String(maxLength: 80));
            AlterColumn("dbo.Foco", "Latitude", c => c.Long());
            AlterColumn("dbo.Foco", "Longitude", c => c.Long());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Foco", "Longitude", c => c.Long(nullable: false));
            AlterColumn("dbo.Foco", "Latitude", c => c.Long(nullable: false));
            AlterColumn("dbo.Endereco", "Bairro", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
