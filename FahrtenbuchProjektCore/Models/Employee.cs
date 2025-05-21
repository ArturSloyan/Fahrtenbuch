using System.ComponentModel.DataAnnotations;

namespace FahrtenbuchProjektCore.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Firstname { get; set; }
        [Required, StringLength(50)]
        public string Secondname { get; set; }
        [Required, StringLength(50)]
        public string Password { get; set; }
    }
}