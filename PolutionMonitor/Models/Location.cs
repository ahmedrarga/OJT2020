namespace PolutionMonitor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Location
    {
        public int locationID { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        public double lat { get; set; }

        public double lng { get; set; }
    }
}
