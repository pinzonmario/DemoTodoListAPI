namespace DemoTodoListAPI.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }

        public List<Subcategory> Subcategories { get; set; } = new List<Subcategory>();
    }
}
