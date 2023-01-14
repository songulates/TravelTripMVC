using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripMVC.Models.Context;
using TravelTripMVC.Models.Entities;

namespace TravelTripMVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        TravelContext context = new TravelContext();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            by.Deger1 = context.Blogs.ToList();
            by.Deger3 = context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(by);
        }
       
        public ActionResult BlogDetay(int id)
        {
            by.Deger1 = context.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = context.Yorums.Where(x => x.BlogId == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorum yorum)
        {
            context.Yorums.Add(yorum);
            context.SaveChanges();
            return PartialView();
        }
    }
}