using System.ComponentModel.DataAnnotations;
namespace task_manager.Models
{
    public enum TaskPriority
    {
        Low,
        Medium,
        High,
        Urgent
    }

    public enum TaskProgress
    {
        InProgress,
        Done,
        ToDo,
        Review
    }

    public class Task
    {
        [Required(ErrorMessage = "The id is required")]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; } = string.Empty;
        [Required]
        public bool IsCompleted { get; set; } = false;
        [Required]
        public TaskPriority Priority { get; set; } = TaskPriority.Medium;
        [Required]
        public TaskProgress Progress { get; set; }
        [Required]
        [StringLength(30)]
        public string Type { get; set; } = string.Empty;
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public TimeSpan Time { get; set; }
    }
}
