namespace super_Heroes_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedInitialMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Heroes", "RealName", c => c.String());
            AddColumn("dbo.Heroes", "AlterEgo", c => c.String());
            AddColumn("dbo.Heroes", "PrimaryAbility", c => c.String());
            AddColumn("dbo.Heroes", "SecondaryAbility", c => c.String());
            AddColumn("dbo.Heroes", "Catchphrase", c => c.String());
            DropColumn("dbo.Heroes", "SuperHeroName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Heroes", "SuperHeroName", c => c.String());
            DropColumn("dbo.Heroes", "Catchphrase");
            DropColumn("dbo.Heroes", "SecondaryAbility");
            DropColumn("dbo.Heroes", "PrimaryAbility");
            DropColumn("dbo.Heroes", "AlterEgo");
            DropColumn("dbo.Heroes", "RealName");
        }
    }
}
