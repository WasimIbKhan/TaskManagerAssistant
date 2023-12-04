using System.ComponentModel.DataAnnotations;
namespace TaskManagerAssistant.Client.Models

{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title must be between 1 and 100 characters")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Due date is required")]
        [ValidFutureDate]
        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }
        // Additional properties like Priority can be added here if needed
    }
}
