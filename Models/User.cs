namespace task_manager.Models
{
    public enum Position
    {
        Developer,
        Manager,
        Designer,
        Tester
    }
     
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Position Position { get; set; } = Position.Developer;
    }
}
