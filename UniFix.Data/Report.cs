using System;

namespace UniFix.Data
{
    public class Report
    {
        public int Id { get; set; }
        public string ReporterName { get; set; }
        public string ReporterPhone { get; set; }
        public string ReporterUsername { get; set; }

        public string Category { get; set; } 
        public string Description { get; set; }
        public string Urgency { get; set; } 
        public string SpecificDetails { get; set; }

        public string Status { get; set; } = "Pending"; 
        public string? AssignedTo { get; set; } 
        public string? DeclineReason { get; set; }

        public DateTime DateReported { get; set; } = DateTime.Now;
        public bool IsHidden { get; set; } = false; 
    }
}