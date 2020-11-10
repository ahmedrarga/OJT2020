namespace PolutionMonitor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Organization
    {
        public int organizationID { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public DateTime subscribtionDate { get; set; }

        public string logo { get; set; }
    }
}
