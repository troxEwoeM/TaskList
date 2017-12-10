namespace TaskList.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PermissionForManipulationWithEmployeesIsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Permissions", "CanAddEmployee", c => c.Boolean(nullable: false));
            AddColumn("dbo.Permissions", "CanEditEmployee", c => c.Boolean(nullable: false));
            AddColumn("dbo.Permissions", "CanRemoveEmployee", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Permissions", "CanRemoveEmployee");
            DropColumn("dbo.Permissions", "CanEditEmployee");
            DropColumn("dbo.Permissions", "CanAddEmployee");
        }
    }
}
