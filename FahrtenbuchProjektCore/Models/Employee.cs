﻿using System.ComponentModel.DataAnnotations;

namespace FahrtenbuchProjektCore.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Firstname { get; set; }
        [Required, StringLength(50)]
        public string Lastname { get; set; }
        [Required, StringLength(50)]
        public string Password { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }

        public ICollection<Journey> Journeys { get; set; }
    }
}