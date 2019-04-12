using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConventionAdvertise.Models
{
    public class ConAdViewModel
    {
        public IEnumerable<ConInformation> ConInformations { get; set; }
    }
}