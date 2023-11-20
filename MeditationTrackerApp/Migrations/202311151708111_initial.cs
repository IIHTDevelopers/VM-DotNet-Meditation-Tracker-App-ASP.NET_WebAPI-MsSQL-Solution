namespace ExpenseTrackerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Meditations",
                c => new
                    {
                        MeditationSessionId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        MeditationType = c.String(),
                        Notes = c.String(),
                        IsFavorite = c.Boolean(nullable: false),
                        Goal = c.String(),
                    })
                .PrimaryKey(t => t.MeditationSessionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Meditations");
        }
    }
}
