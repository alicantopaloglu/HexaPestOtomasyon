using BusinessLayer;
using DataAccessLayer;
using EntityLayer.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HexaPestOtomasyon.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        Context c = new Context();
        PersonelManager pm = new PersonelManager();


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult personelEkle(Personel p)
        {
            // pm.addPersonel(p);
            c.Personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult personelSil(int id)
        {
            pm.silPersonel(id);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    } 
}