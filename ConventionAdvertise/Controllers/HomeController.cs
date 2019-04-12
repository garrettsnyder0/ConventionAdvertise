using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConventionAdvertise.Abstract;
using ConventionAdvertise.Models;
using ConventionAdvertise.Concrete;

namespace ConventionAdvertise.Controllers
{
    public class HomeController : Controller
    {

        private IConAdRepository repository;
        private EFConAdContext db = new EFConAdContext();


        public HomeController(IConAdRepository adRepository)
        {
            this.repository = adRepository;
        }

        public ActionResult Index()
        {
            ConAdViewModel model = new ConAdViewModel
            {
                ConInformations = repository.ConInformations.OrderBy(p => p.StartDate)

            };

            return View(model);
        }
    }
}