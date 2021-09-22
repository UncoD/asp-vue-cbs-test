using System;
using System.Collections.Generic;

namespace ProtectedAreas.Models
{
    public class ProtectedArea
    {
        public int Id { get; set; }
        public string CadastralFileNumber { get; set; }
        public string Status { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public List<ObsoleteName> ObsoleteNames { get; set; }
        public string Category { get; set; }
        public string Significance { get; set; }
        public string Profile { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime RestorationDate { get; set; }
        public List<InternationalStatus> InternationalStatuses { get; set; }
        public List<Liquidation> Liquidations { get; set; }

    }
}
