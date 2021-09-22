using System;

namespace ProtectedAreas.Models
{
    public class Liquidation
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
    }
}