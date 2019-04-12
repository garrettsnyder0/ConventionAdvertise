using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConventionAdvertise.Abstract;
using ConventionAdvertise.Models;

namespace ConventionAdvertise.Concrete
{
    public class EFConAdsRepository : IConAdRepository
    {
        private EFConAdContext context = new EFConAdContext();

        public IEnumerable<ConInformation> ConInformations
        {
            get { return context.ConInformations.AsNoTracking(); }
        }
    }
}