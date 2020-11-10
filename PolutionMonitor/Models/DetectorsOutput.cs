namespace PolutionMonitor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DetectorsOutput
    {
        public int ID { get; set; }

        public int detectorID { get; set; }

        public DateTime timestamp { get; set; }

        public double value { get; set; }
    }
}
