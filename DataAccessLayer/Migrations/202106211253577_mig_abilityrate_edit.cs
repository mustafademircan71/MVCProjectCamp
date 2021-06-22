namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_abilityrate_edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AbilityCards", "ImageUrl", c => c.String(maxLength: 250));
            AddColumn("dbo.AbilityCards", "AbilityRate2", c => c.Int(nullable: false));
            AddColumn("dbo.AbilityCards", "AbilityRate3", c => c.Int(nullable: false));
            AddColumn("dbo.AbilityCards", "AbilityRate4", c => c.Int(nullable: false));
            AddColumn("dbo.AbilityCards", "AbilityRate5", c => c.Int(nullable: false));
            AddColumn("dbo.AbilityCards", "AbilityRate6", c => c.Int(nullable: false));
            AddColumn("dbo.AbilityCards", "AbilityRate7", c => c.Int(nullable: false));
            AddColumn("dbo.AbilityCards", "AbilityRate8", c => c.Int(nullable: false));
            AddColumn("dbo.AbilityCards", "AbilityRate9", c => c.Int(nullable: false));
            AddColumn("dbo.AbilityCards", "AbilityRate10", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AbilityCards", "AbilityRate10");
            DropColumn("dbo.AbilityCards", "AbilityRate9");
            DropColumn("dbo.AbilityCards", "AbilityRate8");
            DropColumn("dbo.AbilityCards", "AbilityRate7");
            DropColumn("dbo.AbilityCards", "AbilityRate6");
            DropColumn("dbo.AbilityCards", "AbilityRate5");
            DropColumn("dbo.AbilityCards", "AbilityRate4");
            DropColumn("dbo.AbilityCards", "AbilityRate3");
            DropColumn("dbo.AbilityCards", "AbilityRate2");
            DropColumn("dbo.AbilityCards", "ImageUrl");
        }
    }
}
