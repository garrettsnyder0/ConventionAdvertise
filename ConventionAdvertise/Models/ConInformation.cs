using System.ComponentModel.DataAnnotations;

namespace ConventionAdvertise.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConInformation
    {
        [Key]
        public int ConID { get; set; }
        public string ConName { get; set; }
        public string LocationOf { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> RegPrice { get; set; }
        public string Website { get; set; }
        public string Hotels { get; set; }
        public string Theme { get; set; }
    }
}
