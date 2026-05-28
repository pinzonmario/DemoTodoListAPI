namespace DemoTodoListAPI.Entities
{
    public class Subcategory
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }

        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }

        public List<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
    }
}
