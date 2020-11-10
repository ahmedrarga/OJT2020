namespace PolutionMonitor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permision
    {
        public int ID { get; set; }

        public int userID { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public int detectorID { get; set; }
    }
}
