namespace task_manager.Models
{
    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }

    public class Task
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;
        public TaskPriority Priority { get; set; } = TaskPriority.Medium;
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public TimeSpan Time { get; set; }
    }
}
