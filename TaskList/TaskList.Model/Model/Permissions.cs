namespace TaskList.Model.Model {
    public class Permissions {
        public int Id { get; set; }
        public bool CanAddTask { get; set; }
        public bool CanTaskTask { get; set; }
        public bool CanDelegateTask { get; set; }
        public bool CanAddEmployee { get; set; }
        public bool CanEditEmployee { get; set; }
        public bool CanRemoveEmployee { get; set; }
    }
}