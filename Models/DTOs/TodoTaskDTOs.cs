using System.ComponentModel.DataAnnotations;

namespace TaskerAPI.Models.DTOs
{
    public class CreateTodoTaskDTO
    {
        [Required]
        [MinLength(3)]
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public DateTime? DueDate { get; set; }
    }

    public class UpdateTodoTaskDTO
    {
        [Required]
        [MinLength(3)]
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public TaskStatus Status { get; set; }
        
        public DateTime? DueDate { get; set; }
    }

    public class TodoTaskResponseDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}