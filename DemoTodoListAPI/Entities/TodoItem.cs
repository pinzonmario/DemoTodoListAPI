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

        public List<TodoItemStep> TodoItemSteps { get; set; } = new List<TodoItemStep>();
        public List<TodoItemFile> TodoItemFiles { get; set; } = new List<TodoItemFile>();
    }
}
