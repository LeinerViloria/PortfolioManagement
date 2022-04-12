using System.ComponentModel.DataAnnotations;

namespace portfolio.Server.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(30)]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(40)]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(15)]
        public string Password { get; set; }
        public bool DbStatus { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string CvUrl { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
