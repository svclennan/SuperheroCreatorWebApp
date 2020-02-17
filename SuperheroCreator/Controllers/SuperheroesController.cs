using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperheroCreator.Data;
using SuperheroCreator.Models;

namespace SuperheroCreator.Controllers
{
    public class SuperheroesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SuperheroesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Superheroes
        public ActionResult Index()
        {
            var heroes = _context.Superheroes;
            return View(heroes);
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
        {
            var hero = _context.Superheroes.Where(a => a.Id == id).SingleOrDefault();
            return View(hero);
        }

        // GET: Superheroes/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superheroes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Superheroes.Add(superhero);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(superhero);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            var hero = _context.Superheroes.Where(a => a.Id == id).SingleOrDefault();
            return View(hero);
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var hero = _context.Superheroes.Where(a => a.Id == id).SingleOrDefault();
                    hero.Name = superhero.Name;
                    hero.PrimarySuperHeroAbility = superhero.PrimarySuperHeroAbility;
                    hero.SecondarySuperHeroAbility = superhero.SecondarySuperHeroAbility;
                    hero.CatchPhrase = superhero.CatchPhrase;
                    hero.AlterEgo = superhero.AlterEgo;
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(superhero);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            var hero = _context.Superheroes.Where(a => a.Id == id).SingleOrDefault();
            return View(hero);
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                _context.Superheroes.Remove(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}