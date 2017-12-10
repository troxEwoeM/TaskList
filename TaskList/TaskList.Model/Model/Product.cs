namespace TaskList.Model.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SourceUri { get; set; }
        public string SourceDocumentation { get; set; }
        public string ClientDocumentation { get; set; }
    }
}