using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripMVC.Models.Context;
using TravelTripMVC.Models.Entities;

namespace TravelTripMVC.Controllers
{
    public class AboutController : Controller
    {

        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            var degerler = context.Hakkimizdas.ToList();

            return View(degerler);
        }
    }
}