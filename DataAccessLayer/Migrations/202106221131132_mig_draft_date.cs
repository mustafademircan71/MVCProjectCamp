namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_draft_date : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drafts", "DraftDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drafts", "DraftDate");
        }
    }
}
