using DemoTodoListAPI.Validations;
using System.ComponentModel.DataAnnotations;

namespace DemoTodoListAPI.DTOs
{
    public class SubcategoryUpdateDTO
    {
        [Required]
        [MaxLength(60)]
        [FirstCapitalLetter]
        public required string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [Required]
        public Guid CategoryId { get; set; }
    }
}
