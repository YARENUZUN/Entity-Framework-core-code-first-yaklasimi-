namespace örnek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ürünler",
                c => new
                    {
                        ÜrünId = c.Int(nullable: false, identity: true),
                        ÜrünAdı = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ÜrünId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ürünler");
        }
    }
}
