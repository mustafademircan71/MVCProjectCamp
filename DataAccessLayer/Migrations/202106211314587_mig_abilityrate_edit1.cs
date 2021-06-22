namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_abilityrate_edit1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AbilityCards", "AbilityRate1", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AbilityCards", "AbilityRate1");
        }
    }
}
