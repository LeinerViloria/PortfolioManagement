using System.ComponentModel.DataAnnotations;

namespace portfolio.Server.Models
{
    public class ProjectImage
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public List<string> ImageUrl { get; set; }
    }
}
