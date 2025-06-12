using System.ComponentModel.DataAnnotations;

namespace FahrtenbuchProjektCore.Models
{
    public class Journey
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="JourneyDate cannot be empty.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM.dd.yyyy}")]
        public DateTime JourneyDate { get; set; }
        [Required(ErrorMessage ="TimeStampStart cannot be empty.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:mm}")]
        public DateTime TimeStampStart { get; set; }
        [Required(ErrorMessage ="TimeStampEnd cannot be empty.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:mm}")]
        public DateTime TimeStampEnd { get; set; }
        [Required(ErrorMessage ="TravelRoute cannot be empty.")]
        [Range(0, int.MaxValue, ErrorMessage = "Value should be greater than or equal to 0")]
        public int TravelRoute { get; set; }
        [Required(ErrorMessage ="PurposeOfTheJourney cannot be empty.")]
        [StringLength(500, ErrorMessage ="PurposeOfTheJourney cannot exceed 500 characters.")]
        public string PurposeOfTheJourney { get; set; }
        // A better max int value for KmDistanceDeparture and KmDistanceArrival would be TravelRoute but i had no time to do that
        [Required(ErrorMessage ="KmDistanceDeparture cannot be empty.")]
        [Range(0, int.MaxValue, ErrorMessage = "Value should be greater than or equal to 0")]
        public int KmDistanceDeparture { get; set; }
        [Required(ErrorMessage ="KmDistanceArrival cannot be empty.")]
        [Range(0, int.MaxValue, ErrorMessage = "Value should be greater than or equal to 0")]
        public int KmDistanceArrival { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public CompanyCar CompanyCar { get; set; }
        // Add a calculated property to expose the LicencePlate
        public string LicencePlate => CompanyCar?.LicencePlate; // Safely access LicencePlate
    }
}
