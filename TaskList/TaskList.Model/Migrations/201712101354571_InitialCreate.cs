namespace TaskList.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fio = c.String(),
                        Number = c.Int(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        SourceUri = c.String(),
                        SourceDocumentation = c.String(),
                        ClientDocumentation = c.String(),
                        Solution_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Solutions", t => t.Solution_Id)
                .Index(t => t.Solution_Id);
            
            CreateTable(
                "dbo.Solutions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TaskItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Done = c.Boolean(nullable: false),
                        Product_Id = c.Int(),
                        Task_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Tasks", t => t.Task_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Task_Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TaskState = c.Int(nullable: false),
                        Client_Id = c.Int(),
                        Executor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Client_Id)
                .ForeignKey("dbo.Employees", t => t.Executor_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Executor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskItems", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.Tasks", "Executor_Id", "dbo.Employees");
            DropForeignKey("dbo.Tasks", "Client_Id", "dbo.Employees");
            DropForeignKey("dbo.TaskItems", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "Solution_Id", "dbo.Solutions");
            DropIndex("dbo.Tasks", new[] { "Executor_Id" });
            DropIndex("dbo.Tasks", new[] { "Client_Id" });
            DropIndex("dbo.TaskItems", new[] { "Task_Id" });
            DropIndex("dbo.TaskItems", new[] { "Product_Id" });
            DropIndex("dbo.Products", new[] { "Solution_Id" });
            DropTable("dbo.Tasks");
            DropTable("dbo.TaskItems");
            DropTable("dbo.Solutions");
            DropTable("dbo.Products");
            DropTable("dbo.Employees");
        }
    }
}
