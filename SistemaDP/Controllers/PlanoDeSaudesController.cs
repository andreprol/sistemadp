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
    public class PlanoDeSaudesController : Controller
    {
        private readonly SistemaDPContext _context;

        public PlanoDeSaudesController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: PlanoDeSaudes
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlanoDeSaude.ToListAsync());
        }

        // GET: PlanoDeSaudes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoDeSaude = await _context.PlanoDeSaude
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planoDeSaude == null)
            {
                return NotFound();
            }

            return View(planoDeSaude);
        }

        // GET: PlanoDeSaudes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlanoDeSaudes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,plano")] PlanoDeSaude planoDeSaude)
        {
            if (ModelState.IsValid)
            {
                planoDeSaude.Id = Guid.NewGuid();
                _context.Add(planoDeSaude);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planoDeSaude);
        }

        // GET: PlanoDeSaudes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoDeSaude = await _context.PlanoDeSaude.FindAsync(id);
            if (planoDeSaude == null)
            {
                return NotFound();
            }
            return View(planoDeSaude);
        }

        // POST: PlanoDeSaudes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,plano")] PlanoDeSaude planoDeSaude)
        {
            if (id != planoDeSaude.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planoDeSaude);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanoDeSaudeExists(planoDeSaude.Id))
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
            return View(planoDeSaude);
        }

        // GET: PlanoDeSaudes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoDeSaude = await _context.PlanoDeSaude
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planoDeSaude == null)
            {
                return NotFound();
            }

            return View(planoDeSaude);
        }

        // POST: PlanoDeSaudes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var planoDeSaude = await _context.PlanoDeSaude.FindAsync(id);
            _context.PlanoDeSaude.Remove(planoDeSaude);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanoDeSaudeExists(Guid id)
        {
            return _context.PlanoDeSaude.Any(e => e.Id == id);
        }
    }
}
