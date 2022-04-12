using System.ComponentModel.DataAnnotations;

namespace portfolio.Server.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string GitHubUrl { get; set; }
    }
}
