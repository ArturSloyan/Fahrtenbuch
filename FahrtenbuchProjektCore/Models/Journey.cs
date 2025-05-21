using System.ComponentModel.DataAnnotations;

namespace FahrtenbuchProjektCore.Models
{
    public class Journey
    {
        [Key]
        public int Id { get; set; }
        [Required, DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM.dd.yyyy}")]
        public DateTime JourneyDate { get; set; }
        [Required, DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:mm:ss}")]
        public DateTime TimeStampStart { get; set; }
        [Required, DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:mm:ss}")]
        public DateTime TimeStampEnd { get; set; }
        [Required, Range(0, int.MaxValue, ErrorMessage = "Value should be greater than or equal to 0")]
        public int TravelRoute { get; set; }
        [Required, StringLength(500)]
        public string PurposeOfTheJourney { get; set; }
        // A better max int value for KmDistanceDeparture and KmDistanceArrival would be TravelRoute but i had no time to do that
        [Required, Range(0, int.MaxValue, ErrorMessage = "Value should be greater than or equal to 0")]
        public int KmDistanceDeparture { get; set; }
        [Required, Range(0, int.MaxValue, ErrorMessage = "Value should be greater than or equal to 0")]
        public int KmDistanceArrival { get; set; }

        public Employee Employee { get; set; }
        public CompanyCar CompanyCar { get; set; }
    }
}
