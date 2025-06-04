namespace FinalKonusu2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.hastas",
                c => new
                    {
                        hastaId = c.Int(nullable: false, identity: true),
                        hastaAdi = c.String(),
                        hastaSoyAdi = c.String(),
                        hastaYasi = c.Int(nullable: false),
                        gittigiBolum = c.String(),
                    })
                .PrimaryKey(t => t.hastaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.hastas");
        }
    }
}
