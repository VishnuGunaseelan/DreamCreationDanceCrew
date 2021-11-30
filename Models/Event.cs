using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DreamCreationDanceCrew.Models
{
    public class Event
    {
        public int ID { get; set; }
        [RegularExpression("(?i)training")]
        [Required]
        public string Type { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime TimeFrom { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime TimeUntil { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Group { get; set; }
        public string BringWith { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Description { get; set; }
    }
}