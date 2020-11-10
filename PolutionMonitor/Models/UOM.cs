namespace PolutionMonitor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UOM")]
    public partial class UOM
    {
        public int UomID { get; set; }

        [Column("Uom")]
        [Required]
        [StringLength(50)]
        public string Uom1 { get; set; }
    }
}
