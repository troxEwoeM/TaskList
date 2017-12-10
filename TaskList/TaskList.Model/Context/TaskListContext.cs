using System.Data.Entity;
using TaskList.Model.Model;

namespace TaskList.Model.Context {
    public class TaskListContext : DbContext {

        public TaskListContext() : base("TaskListDatabase")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Permissions> Permissionses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<Task> Tasks { get; set; }

    }
}
