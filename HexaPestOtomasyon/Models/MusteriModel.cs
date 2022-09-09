using EntityLayer.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HexaPestOtomasyon.Models
{
    public class MusteriModel
    {
        public Musteri  Musteris { get; set; }
        public IEnumerable<SelectListItem> sehirler { get; set; }
        public IEnumerable<SelectListItem> ilceler { get; set; }
    }
}