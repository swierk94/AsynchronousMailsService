namespace Versus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Data : DbMigration
    {
        public override void Up()
        {
           
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Score1 = c.Int(nullable: false),
                        Score2 = c.Int(nullable: false),
                        GameId = c.String(),
                        BetDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
           
        }
        
        public override void Down()
        {
            
            DropTable("dbo.Scores");
           
        }
    }
}
