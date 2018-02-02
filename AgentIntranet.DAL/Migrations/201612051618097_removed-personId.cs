namespace AgentIntranet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedpersonId : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Agents", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "Email", c => c.String(maxLength: 50));
            DropColumn("dbo.Agents", "PersonId");
            DropColumn("dbo.Customers", "PersonId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "PersonId", c => c.Int(nullable: false));
            AddColumn("dbo.Agents", "PersonId", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Email", c => c.String(maxLength: 25));
            AlterColumn("dbo.Agents", "Email", c => c.String(maxLength: 25));
        }
    }
}
