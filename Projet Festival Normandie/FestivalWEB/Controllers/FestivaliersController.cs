using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FestivalAPI.Data;
using FestivalAPI.Models;

namespace FestivalWEB.Controllers
{
    public class FestivaliersController : Controller
    {
        private readonly FestivalAPIContext _context;

        public FestivaliersController(FestivalAPIContext context)
        {
            _context = context;
        }

        // GET: Festivaliers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Festivalier.ToListAsync());
        }

        // GET: Festivaliers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var festivalier = await _context.Festivalier
                .FirstOrDefaultAsync(m => m.IdUser == id);
            if (festivalier == null)
            {
                return NotFound();
            }

            return View(festivalier);
        }

        // GET: Festivaliers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Festivaliers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUser,Nom,Prenom,Mot_de_passe,Email,Genre,Telephone,Code_postal,Commune,Pays,Date_de_naissance")] Festivalier festivalier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(festivalier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(festivalier);
        }

        // GET: Festivaliers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var festivalier = await _context.Festivalier.FindAsync(id);
            if (festivalier == null)
            {
                return NotFound();
            }
            return View(festivalier);
        }

        // POST: Festivaliers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUser,Nom,Prenom,Mot_de_passe,Email,Genre,Telephone,Code_postal,Commune,Pays,Date_de_naissance")] Festivalier festivalier)
        {
            if (id != festivalier.IdUser)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(festivalier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FestivalierExists(festivalier.IdUser))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(festivalier);
        }

        // GET: Festivaliers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var festivalier = await _context.Festivalier
                .FirstOrDefaultAsync(m => m.IdUser == id);
            if (festivalier == null)
            {
                return NotFound();
            }

            return View(festivalier);
        }

        // POST: Festivaliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var festivalier = await _context.Festivalier.FindAsync(id);
            _context.Festivalier.Remove(festivalier);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FestivalierExists(int id)
        {
            return _context.Festivalier.Any(e => e.IdUser == id);
        }
    }
}
