using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProtectedAreas.Models
{
    public class ProtectedArea
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string CadastralFileNumber { get; set; }
        [MaxLength(150)]
        public string Status { get; set; }
        [MaxLength(150)]
        public string FullName { get; set; }
        [MaxLength(150)]
        public string ShortName { get; set; }
        [MaxLength(150)]
        public string Category { get; set; }
        [MaxLength(150)]
        public string Significance { get; set; }
        [MaxLength(150)]
        public string Profile { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime RestorationDate { get; set; }
        public List<InternationalStatus> InternationalStatuses { get; set; }
        public List<Liquidation> Liquidations { get; set; }
        public List<ObsoleteName> ObsoleteNames { get; set; }

    }
}
