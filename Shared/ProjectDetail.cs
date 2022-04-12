using System.ComponentModel.DataAnnotations;

namespace portfolio.Server.Models
{
    public class ProjectDetail
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public List<int> TechnologyId { get; set; }
    }
}
