using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ConventionAdvertise.Models;

namespace ConventionAdvertise.Concrete
{
    public class EFConAdContext : DbContext
    {

        public DbSet<ConInformation> ConInformations { get; set; }
        public DbContext db;

        public EFConAdContext() : base("EFConAdContext")
        {

        }
    }
}