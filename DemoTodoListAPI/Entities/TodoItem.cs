namespace DemoTodoListAPI.Entities
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime Reminder { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }

        public Guid SubcategoryId { get; set; }
        public Subcategory? Subcategory { get; set; }

        public IEnumerable<TodoItemStep> TodoItemSteps { get; set; } = [];
        public IEnumerable<TodoItemFile> TodoItemFiles { get; set; } = [];
    }
}
