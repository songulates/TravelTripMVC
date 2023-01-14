using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripMVC.Models.Context;
using TravelTripMVC.Models.Entities;

namespace TravelTripMVC.Controllers
{
    public class AdminController : Controller
    {
        TravelContext context = new TravelContext();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = context.Blogs.ToList();
            return View(degerler); 
        }
        [HttpGet]
        public ActionResult BlogEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BlogEkle(Blog blog)
        {
            //blog içerisine parametreden gelen değeri ekle
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var removeblog = context.Blogs.Find(id);
            context.Blogs.Remove(removeblog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
       
        public ActionResult BlogGuncelle(int id)
        {
            var guncel = context.Blogs.Find(id);
            return View("BlogGuncelle", guncel);
        }
        //[HttpPost]
        public ActionResult BlogUpdate(Blog blog)
        {
            var guncelle = context.Blogs.Find(blog.ID);
            guncelle.Aciklama = blog.Aciklama;
            guncelle.Tarih = blog.Tarih;
            guncelle.BlogImage = blog.BlogImage;
            guncelle.Baslik = blog.Baslik;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListele()
        {
            var yorum = context.Yorums.ToList();
            return View(yorum);
        }
        public ActionResult YorumSil(int id)
        {
            var removeyorum = context.Yorums.Find(id);
            context.Yorums.Remove(removeyorum);
            context.SaveChanges();
            return RedirectToAction("YorumListele");
        }
        public ActionResult YorumGetir(int id)
        {
            var yorum = context.Yorums.Find(id);
            return View("YorumGetir",yorum);
        }
        public ActionResult YorumGuncelle(Yorum yorum)
        {
            var guncelle = context.Yorums.Find(yorum.ID);
            guncelle.Kullanici = yorum.Kullanici;
            guncelle.Mail = yorum.Mail;
            guncelle.Yorumlar = yorum.Yorumlar;
           
            context.SaveChanges();
            return RedirectToAction("YorumListele");
        }
    }
}