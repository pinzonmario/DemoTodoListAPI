namespace DemoTodoListAPI.Entities
{
    public class TodoItemFile
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }
        public string? Path { get; set; }
        public string? ContentType { get; set; }
        public DateTime UploadedAt { get; set; }

        public Guid TodoItemId { get; set; }
        public TodoItem? TodoItem { get; set; }
    }
}
