namespace CodeCampSdq.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Description = c.String(nullable: false),
                        Location = c.String(nullable: false, maxLength: 200),
                        StartTime = c.Time(nullable: false, precision: 7),
                        EndTime = c.Time(nullable: false, precision: 7),
                        SpeakerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Speakers", t => t.SpeakerId, cascadeDelete: true)
                .Index(t => t.SpeakerId);
            
            CreateTable(
                "dbo.Speakers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Bio = c.String(),
                        Url = c.String(),
                        PhotoUrl = c.String(),
                        TwitterAccount = c.String(maxLength: 200),
                        FacebookAccount = c.String(maxLength: 200),
                        GitHubAccount = c.String(maxLength: 200),
                        LinkedInAccount = c.String(maxLength: 200),
                        GooglePlusAccount = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sessions", "SpeakerId", "dbo.Speakers");
            DropIndex("dbo.Sessions", new[] { "SpeakerId" });
            DropTable("dbo.Speakers");
            DropTable("dbo.Sessions");
        }
    }
}
