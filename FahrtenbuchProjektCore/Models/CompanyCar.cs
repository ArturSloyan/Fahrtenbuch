using System.ComponentModel.DataAnnotations;

namespace FahrtenbuchProjektCore.Models
{
    public class CompanyCar
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Brand { get; set; }
        [Required, Range(0, 7, ErrorMessage = "Value should be greater than or equal to 1")]
        public CarType CarType { get; set; }
        [Required, StringLength(10)]
        public string LicencePlate { get; set; }

        public ICollection<Journey> Journeys { get; set; }
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