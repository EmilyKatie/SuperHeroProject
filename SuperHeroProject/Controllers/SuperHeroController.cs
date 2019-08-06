using SuperHeroProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroProject.Controllers
{
    public class SuperHeroController : Controller
    {
        // GET: SuperHero
        ApplicationDbContext db;
        public SuperHeroController()
        {
             db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            SuperHero superHero = new SuperHero();
            return View();
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int id)
        {
            SuperHero superHero = new SuperHero();
            return View();
        }

        // GET: SuperHero/Create
        public ActionResult Create()
        {
            SuperHero superHero = new SuperHero();
            return View(superHero);
        }

        // POST: SuperHero/Create
        [HttpPost]
        public ActionResult Create(SuperHero superHero)
        {
            try
            { 
                //TODO: Add insert logic here
                db.SuperHero.Add(superHero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                
                return View();
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit()
        {
            SuperHero superHero = new SuperHero();
            return View();
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        public ActionResult Edit(int Id)
        {
            try
            {
                // TODO: Add update logic here
                db.SuperHero.Where(s => s.Id == Id);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete()
        {
            SuperHero superHero = new SuperHero();
            return View();
        }

        // POST: SuperHero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SuperHero superHero)
        {
            try
            {
                // TODO: Add delete logic here
                db.SuperHero.Remove(superHero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
