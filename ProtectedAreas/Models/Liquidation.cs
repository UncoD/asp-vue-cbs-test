using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProtectedAreas.Models
{
    public class Liquidation
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        [MaxLength(150)]
        public string Type { get; set; }
        public DateTime Date { get; set; }

        public int ProtectedAreaId { get; set; }
        [ForeignKey("ProtectedAreaId")]
        [JsonIgnore]
        public ProtectedArea ProtectedArea { get; set; }
    }
}