using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripMVC.Models.Entities
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Yorum> Yorums { get; set; }
       //bir blogda birden fazla yorum yaoılabilir. ama 1 yorum 1 bloga yapılır
    }
}