﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripMVC.Models.Entities
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public string FotoUrl { get; set; }
        public string Aciklama { get; set; }
    }
}