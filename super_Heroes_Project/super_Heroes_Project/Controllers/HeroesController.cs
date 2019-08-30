using super_Heroes_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace super_Heroes_Project.Controllers
{
    public class HeroesController : Controller
    {
        ApplicationDbContext context;
        public HeroesController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Heroes
        public ActionResult Index()
        {
            List<Heroes> heroList = context.SuperHeroes.ToList();
            
            return View(heroList);
        }

        // GET: Heroes/Details/5
        public ActionResult Details(int id)
        {
            Heroes hero = context.SuperHeroes.Where(h => h.Id == id).Single();
            return View(hero);
        }
        [HttpPost]
        public ActionResult Details(Heroes hero)
        {
            Heroes heroToDisplay = context.SuperHeroes.Where(h => h.Id == hero.Id).Single();
            return RedirectToAction("Details", "Heroes");
        }

        // GET: Heroes/Create
        public ActionResult Create()
        {
            Heroes hero = new Heroes();
            return View(hero);
        }

        // POST: Heroes/Create
        [HttpPost]
        public ActionResult Create(Heroes hero)
        {
            try
            {
                // TODO: Add insert logic here
                context.SuperHeroes.Add(hero);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: Heroes/Edit/5
        public ActionResult Edit(int id)
        {
            var hero = context.SuperHeroes.Where(h => h.Id == id).Single();
            return View(hero);
        }

        // POST: Heroes/Edit/5
        [HttpPost]
        public ActionResult Edit(Heroes hero)
        {
            try
            {
                // TODO: Add update logic here
                var heroToEdit = context.SuperHeroes.Where(h => h.Id == hero.Id).Single();
                heroToEdit.RealName = hero.RealName;
                heroToEdit.AlterEgo = hero.AlterEgo;
                heroToEdit.PrimaryAbility = hero.PrimaryAbility;
                heroToEdit.SecondaryAbility = hero.SecondaryAbility;
                heroToEdit.Catchphrase = hero.Catchphrase;
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: Heroes/Delete/5
        public ActionResult Delete(int id)
        {
            var hero = context.SuperHeroes.Where(h => h.Id == id).Single();
            return View(hero);
        }

        // POST: Heroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Heroes hero)
        {
            try
            {
                var heroToDelete = context.SuperHeroes.Where(h => h.Id == hero.Id).Single();
                context.SuperHeroes.Remove(heroToDelete);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index", "Home");
            }
        }
    }
}
