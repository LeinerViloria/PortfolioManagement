using System.ComponentModel.DataAnnotations;

namespace portfolio.Server.Models
{
    public class ProgrammingTool
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20)]
        public string Name { get; set; }
    }
}
