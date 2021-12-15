using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DreamCreationDanceCrew.Models
{
    public enum Types
    {
        Training,
        Hauptprobe,
        Sitzung,
        Auftritt,
        Speziell
    }

    public enum Groups
    {
        Trainer,
        Elite,
        Schüler
    }

    public class EnumModel
    {
        public Groups Group { get; set; }
        public bool IsSelected { get; set; }
    }

    public class Event
    {
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public Types Type { get; set; }
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
        [Column(TypeName = "nvarchar(40)")]
        public List<EnumModel> CheckboxGroups { get; set; }
        public string BringWith { get; set; }
        public string Description { get; set; }
    }
}