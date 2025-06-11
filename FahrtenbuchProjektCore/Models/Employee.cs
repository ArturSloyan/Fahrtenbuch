using System.ComponentModel.DataAnnotations;

namespace FahrtenbuchProjektCore.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Firstname cannot be empty.")]
        [StringLength(50, ErrorMessage ="Firstname cannot exceed 50 characters.")]
        public string Firstname { get; set; }
        [Required(ErrorMessage ="Lastname cannot be empty.")]
        [StringLength(50, ErrorMessage ="Lastname cannot exceed 50 characters.")]
        public string Lastname { get; set; }
        [Required(ErrorMessage ="Password cannot be empty.")]
        [StringLength(50, ErrorMessage ="Password cannot exceed 50 characters.")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Email cannot be empty.")]
        [StringLength(50, ErrorMessage ="Email cannot exceed 50 characters.")]
        public string Email { get; set; }

        public ICollection<Journey> Journeys { get; set; }
    }
}