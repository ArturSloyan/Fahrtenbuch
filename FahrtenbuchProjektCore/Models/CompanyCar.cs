using FahrtenbuchProjektCore.CustomAnnotation;
using System.ComponentModel.DataAnnotations;

namespace FahrtenbuchProjektCore.Models
{
    public class CompanyCar
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Brand cannot be empty.")]
        [StringLength(50, ErrorMessage ="Brand cannot exceed 50 characters.")]
        public string Brand { get; set; }
        [Required(ErrorMessage ="Car type cannot be empty.")]
        [Range(0, 7, ErrorMessage = "Index can only be between 0 and 7.")]
        public CarType CarType { get; set; }
        [Required(ErrorMessage ="Licenceplate cannot be empty.")]
        [StringLength(10, ErrorMessage ="Licenceplate cannot exceed 10 characters.")]
        [LicencePlatePattern(ErrorMessage = "Licenceplate are only allowed \"???-###\"")]
        public string LicencePlate { get; set; }

        public ICollection<Journey> Journeys { get; set; }

        public override string ToString()
        {
            return LicencePlate;
        }
    }

    // IF YOU CHANGE SOMETHING HERE CONSIDER TO DO SO IN THE DATABASE AND IN THE DATAANNOTATION OF PROPERTY "CarType"
    public enum CarType
    {
        None,
        Hatchback,
        Sedan,
        SUV,
        MUV,
        Coupe,
        Convertible,
        PickupTruck
    }
}