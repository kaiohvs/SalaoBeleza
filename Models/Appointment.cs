using System;
using System.ComponentModel.DataAnnotations;

namespace SalaoBeleza.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string Service { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan Time { get; set; }

        public string Notes { get; set; }
    }
}
