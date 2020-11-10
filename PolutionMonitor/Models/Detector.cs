namespace PolutionMonitor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Detector")]
    public partial class Detector
    {
        public int DetectorID { get; set; }

        [Required]
        [StringLength(20)]
        public string name { get; set; }

        public int locationID { get; set; }

        public int TypeID { get; set; }

        public DateTime installDate { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public double OutputRate { get; set; }

        public bool IsActive { get; set; }

        public bool IsPublic { get; set; }
    }
}
