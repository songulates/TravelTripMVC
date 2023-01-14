using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripMVC.Models.Context;
using TravelTripMVC.Models.Entities;

namespace TravelTripMVC.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            var deger = context.Blogs.Take(4).ToList();
            return View(deger);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = context.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = context.Blogs.Where(x => x.ID==1).ToList();
            return PartialView(degerler);
        }
        //en beğendiğimiz yerler
        public PartialViewResult Partial3()
        {
            var deger = context.Blogs.Take(1).ToList();
            return PartialView(deger);
        }
    }
}