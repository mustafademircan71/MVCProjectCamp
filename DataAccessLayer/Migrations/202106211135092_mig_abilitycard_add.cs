namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_abilitycard_add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbilityCards",
                c => new
                    {
                        AbilityCardId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(maxLength: 250),
                        FullName = c.String(maxLength: 50),
                        Ability1 = c.String(maxLength: 100),
                        Ability2 = c.String(maxLength: 100),
                        Ability3 = c.String(maxLength: 100),
                        Ability4 = c.String(maxLength: 100),
                        Ability5 = c.String(maxLength: 100),
                        Ability6 = c.String(maxLength: 100),
                        Ability7 = c.String(maxLength: 100),
                        Ability8 = c.String(maxLength: 100),
                        Ability9 = c.String(maxLength: 100),
                        Ability10 = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.AbilityCardId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AbilityCards");
        }
    }
}
