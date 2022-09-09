using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLayer.Siniflar;
using HexaPestOtomasyon.Models;
using BusinessLayer;
using System.Data.Entity.Validation;
using System.Diagnostics;
using Serilog;
using System.Net;
using System.Threading.Tasks;

namespace HexaPestOtomasyon.Controllers
{
    public class EnvanterController : Controller
    {
        // GET: Envanter
        Context c = new Context();
        PestisitManager pm = new PestisitManager();
        EkipmanManager em = new EkipmanManager();
        public ActionResult Index()
        {
            var pest = c.Pestisits.Where(x => x.aktif == true).Count();

            int ekip = c.Ekipmans.Where(x => x.aktif == true).Count();

            ViewBag.pestisit = pest;
            ViewBag.ekipman = ekip;

            return View();

            
        }

        [HttpPost]
        public ActionResult pestisitEkle(EnvanterModel em)
        {

            //pm.pestisitEkle(em.Pestisits);
            c.Pestisits.Add(em.Pestisits);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult pestisitSil(int id)
        {
            pm.silPestisit(id);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult ekipmanEkle(EnvanterModel em)
        {
            c.Ekipmans.Add(em.Ekipmans);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ekipmanSil(int id)
        {
            em.ekipmanSil(id);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}