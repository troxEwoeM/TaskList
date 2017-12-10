using TaskList.Model.Model;

namespace TaskList.Model.Migrations {
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.TaskListContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = true;
            ContextKey = "TaskList.Model.Context.TaskListContext";
        }

        protected override void Seed(Context.TaskListContext context) {
            var employee = new Employee
            {
                Login = "admin",
                Password = "qweqwe",
                Fio = "Administrator",
                Number = 0
            };

            var permission = new Permissions
            {
                CanAddTask = true,
                CanDelegateTask = true,
                CanTaskTask = true,
                CanAddEmployee = true,
                CanEditEmployee = true,
                CanRemoveEmployee = true
            };

            employee.Permissions = permission;

            context.Permissionses.AddOrUpdate(permission);
            context.Employees.AddOrUpdate(employee);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
