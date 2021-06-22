namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_abilitycard_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AbilityCards", "Title", c => c.String(maxLength: 250));
            DropColumn("dbo.AbilityCards", "ImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AbilityCards", "ImageUrl", c => c.String(maxLength: 250));
            DropColumn("dbo.AbilityCards", "Title");
        }
    }
}
