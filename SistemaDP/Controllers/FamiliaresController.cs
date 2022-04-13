using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaDP.Data;
using SistemaDP.Models;

namespace SistemaDP.Controllers
{
    public class FamiliaresController : Controller
    {
        private readonly SistemaDPContext _context;

        public FamiliaresController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: Familiares
        public async Task<IActionResult> Index()
        {
            return View(await _context.Familiares.ToListAsync());
        }

        // GET: Familiares/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familiares = await _context.Familiares
                .FirstOrDefaultAsync(m => m.Id == id);
            if (familiares == null)
            {
                return NotFound();
            }

            return View(familiares);
        }

        // GET: Familiares/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Familiares/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,nome_pai,nome_mae,nome_filho,nasc_filho")] Familiares familiares)
        {
            if (ModelState.IsValid)
            {
                familiares.Id = Guid.NewGuid();
                _context.Add(familiares);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(familiares);
        }

        // GET: Familiares/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familiares = await _context.Familiares.FindAsync(id);
            if (familiares == null)
            {
                return NotFound();
            }
            return View(familiares);
        }

        // POST: Familiares/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,nome_pai,nome_mae,nome_filho,nasc_filho")] Familiares familiares)
        {
            if (id != familiares.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(familiares);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FamiliaresExists(familiares.Id))
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
            return View(familiares);
        }

        // GET: Familiares/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familiares = await _context.Familiares
                .FirstOrDefaultAsync(m => m.Id == id);
            if (familiares == null)
            {
                return NotFound();
            }

            return View(familiares);
        }

        // POST: Familiares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var familiares = await _context.Familiares.FindAsync(id);
            _context.Familiares.Remove(familiares);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FamiliaresExists(Guid id)
        {
            return _context.Familiares.Any(e => e.Id == id);
        }
    }
}
