namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_drafft_add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drafts",
                c => new
                    {
                        DraftId = c.Int(nullable: false, identity: true),
                        ReciverMail = c.String(maxLength: 50),
                        Subject = c.String(maxLength: 100),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.DraftId);
            
            DropColumn("dbo.Messages", "Draft");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "Draft", c => c.Boolean(nullable: false));
            DropTable("dbo.Drafts");
        }
    }
}
