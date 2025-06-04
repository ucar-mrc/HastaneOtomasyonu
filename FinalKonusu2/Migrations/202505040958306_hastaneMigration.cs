namespace FinalKonusu2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hastaneMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doktors",
                c => new
                    {
                        doktorId = c.Int(nullable: false, identity: true),
                        doktorAdi = c.String(),
                        doktorSoyadi = c.String(),
                        doktorYasi = c.Int(nullable: false),
                        uzmanlik = c.String(),
                    })
                .PrimaryKey(t => t.doktorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Doktors");
        }
    }
}
