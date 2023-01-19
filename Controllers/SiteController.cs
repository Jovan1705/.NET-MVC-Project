using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekat1.Models;

namespace Projekat1.Controllers
{
    public class SiteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kontakt()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UnosAuta()
        {
            Tip[] tipovi = new Tip[]
            {
                new Tip("Limuzina"),
                new Tip("Hecbek"),
                new Tip("Karavan"),
                new Tip("SUV"),
                new Tip("Kabriolet"),
                new Tip("Kupe")
            };
            List<string> vrsta = new List<string>();
            foreach(Tip x in tipovi)
            {
                vrsta.Add(x.vrsta);
            }

            ViewBag.vrsta = vrsta;
            return View();
        }
        [HttpPost]
        public ActionResult UnosAuta(MainModel auto)
        {
            return View("PrikazAuta", auto);
        }

        [HttpGet]
        public ActionResult UnosMotora()
        {
            Tip[] tipovi = new Tip[]
            {
                new Tip("Kvad"),
                new Tip("Skuter"),
                new Tip("Sport"),
                new Tip("Super sport"),
                new Tip("Čoper")
            };
            List<string> vrsta = new List<string>();
            foreach (Tip x in tipovi)
            {
                vrsta.Add(x.vrsta);
            }

            ViewBag.vrsta = vrsta;
            return View();
        }
        [HttpPost]
        public ActionResult UnosMotora(MainModel motor)
        {
            return View("PrikazMotora", motor);
        }
    }
}