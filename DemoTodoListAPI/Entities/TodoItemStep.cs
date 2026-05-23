namespace DemoTodoListAPI.Entities
{
    public class TodoItemStep
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public int Order { get; set; }

        public Guid TodoItemId { get; set; }
        public TodoItem? TodoItem { get; set; }
    }
}
