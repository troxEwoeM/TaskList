namespace TaskList.Model.Model
{
    public class TaskItem
    {
        public int Id { get; set; }
        public virtual Product Product { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}