namespace CodeCampSdq.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpeakerEmailField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Speakers", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Speakers", "Email");
        }
    }
}
