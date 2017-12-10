namespace TaskList.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeePermissions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CanAddTask = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "Permissions_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Permissions_Id");
            AddForeignKey("dbo.Employees", "Permissions_Id", "dbo.Permissions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Permissions_Id", "dbo.Permissions");
            DropIndex("dbo.Employees", new[] { "Permissions_Id" });
            DropColumn("dbo.Employees", "Permissions_Id");
            DropTable("dbo.Permissions");
        }
    }
}
