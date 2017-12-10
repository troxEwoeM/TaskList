namespace TaskList.Model.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public int Number { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte[] Photo { get; set; }
        
        public virtual Permissions Permissions { get; set; }
    }
}