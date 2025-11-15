using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "The id is necessaire")]
        public Guid Id { get; set; }
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; } = string.Empty;
        [StringLength(40)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public Position Position { get; set; } = Position.Developer;
    }
}
