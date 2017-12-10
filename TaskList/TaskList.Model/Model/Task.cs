using System.Collections.Generic;

namespace TaskList.Model.Model
{
    public class Task
    {
        public int Id { get; set; }
        public virtual Employee Client { get; set; }
        public virtual Employee Executor { get; set; }
        public virtual List<TaskItem> TaskItems { get; set; }
        public TaskState TaskState { get; set; }
    }
}