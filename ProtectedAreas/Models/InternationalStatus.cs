using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProtectedAreas.Models
{
    public class InternationalStatus
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        [MaxLength(100)]
        public string Status { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Document { get; set; }
        
        public int ProtectedAreaId { get; set; }
        [ForeignKey("ProtectedAreaId")]
        [JsonIgnore]
        public ProtectedArea ProtectedArea { get; set; }
    }
}