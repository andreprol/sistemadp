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
    public class HistoricoFeriasController : Controller
    {
        private readonly SistemaDPContext _context;

        public HistoricoFeriasController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: HistoricoFerias
        public async Task<IActionResult> Index()
        {
            return View(await _context.HistoricoFerias.ToListAsync());
        }

        // GET: HistoricoFerias/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoFerias = await _context.HistoricoFerias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicoFerias == null)
            {
                return NotFound();
            }

            return View(historicoFerias);
        }

        // GET: HistoricoFerias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HistoricoFerias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,datainicio,datafim,datagozo,valorferias,abonoferias,diasgozo,diasvendidos,valorvendido")] HistoricoFerias historicoFerias)
        {
            if (ModelState.IsValid)
            {
                historicoFerias.Id = Guid.NewGuid();
                _context.Add(historicoFerias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(historicoFerias);
        }

        // GET: HistoricoFerias/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoFerias = await _context.HistoricoFerias.FindAsync(id);
            if (historicoFerias == null)
            {
                return NotFound();
            }
            return View(historicoFerias);
        }

        // POST: HistoricoFerias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,datainicio,datafim,datagozo,valorferias,abonoferias,diasgozo,diasvendidos,valorvendido")] HistoricoFerias historicoFerias)
        {
            if (id != historicoFerias.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historicoFerias);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistoricoFeriasExists(historicoFerias.Id))
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
            return View(historicoFerias);
        }

        // GET: HistoricoFerias/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoFerias = await _context.HistoricoFerias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicoFerias == null)
            {
                return NotFound();
            }

            return View(historicoFerias);
        }

        // POST: HistoricoFerias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var historicoFerias = await _context.HistoricoFerias.FindAsync(id);
            _context.HistoricoFerias.Remove(historicoFerias);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricoFeriasExists(Guid id)
        {
            return _context.HistoricoFerias.Any(e => e.Id == id);
        }
    }
}
