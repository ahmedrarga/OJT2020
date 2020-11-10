namespace PolutionMonitor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetectorTpye")]
    public partial class DetectorTpye
    {
        [Key]
        public int typeID { get; set; }

        [StringLength(50)]
        public string category { get; set; }

        public int uomID { get; set; }
    }
}
