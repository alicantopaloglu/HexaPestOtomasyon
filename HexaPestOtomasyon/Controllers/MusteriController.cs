using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLayer.Siniflar;
using BusinessLayer;
using DataAccessLayer;
using HexaPestOtomasyon.Models;

namespace HexaPestOtomasyon.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        Context c = new Context();
        SehirCascading sc = new SehirCascading();
        MusteriModel mm = new MusteriModel();
        MusteriManager ms = new MusteriManager();


        public ActionResult Index()
        {

            mm.sehirler = new SelectList(c.Sehirs, "ID", "sehirAdi");
            mm.ilceler = new SelectList(c.Ilces, "ID", "ilceAdi");




            return View(mm);
        }

        [HttpPost]
        public ActionResult musteriEkle(MusteriModel m)
        {
            c.Musteris.Add(m.Musteris);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult ilceGetir(int p)
        {
            var ilceler = (from x in c.Ilces
                           join y in c.Sehirs on x.sehirID equals y.ID
                           where x.sehirID == p
                           select new
                           {
                               Text = x.ilceAdi,
                               Value = x.ilceAdi
                           }).ToList();
            return Json(ilceler, JsonRequestBehavior.AllowGet);
        }

        public ActionResult musteriDuzenle(MusteriModel m)
        {
            var musteri = c.Musteris.Find(m.Musteris.ID);

            if (string.IsNullOrEmpty(m.Musteris.sifre.ToString()))
            {

                musteri.ilce = m.Musteris.ilce;
                musteri.sehir = m.Musteris.sehir;
                musteri.sabitTel = m.Musteris.sabitTel;
                musteri.sabitTel2 = m.Musteris.sabitTel2;
                musteri.mobilTel = m.Musteris.mobilTel;
                musteri.mobilTel2 = m.Musteris.mobilTel2;
                musteri.adi = m.Musteris.adi;
                musteri.adres = m.Musteris.adres;
                musteri.firmaAdi = m.Musteris.firmaAdi;
            }
            else
            {

                musteri.ilce = m.Musteris.ilce;
                musteri.sehir = m.Musteris.sehir;
                musteri.sabitTel = m.Musteris.sabitTel;
                musteri.sabitTel2 = m.Musteris.sabitTel2;
                musteri.mobilTel = m.Musteris.mobilTel;
                musteri.mobilTel2 = m.Musteris.mobilTel2;
                musteri.sifre = m.Musteris.sifre;
                musteri.adi = m.Musteris.adi;
                musteri.adres = m.Musteris.adres;
                musteri.firmaAdi = m.Musteris.firmaAdi;
            }

            c.SaveChanges();
            return RedirectToAction("Index");


        }

        public ActionResult silMusteri(MusteriModel m)
        {
            ms.musteriSil(m.Musteris.ID);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}