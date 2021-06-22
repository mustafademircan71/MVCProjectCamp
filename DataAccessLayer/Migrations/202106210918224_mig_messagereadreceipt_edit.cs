namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_messagereadreceipt_edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "ReadReceipt", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "ReadReceipt");
        }
    }
}
