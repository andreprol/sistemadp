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
    public class TarifasDeOnibusController : Controller
    {
        private readonly SistemaDPContext _context;

        public TarifasDeOnibusController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: TarifasDeOnibus
        public async Task<IActionResult> Index()
        {
            return View(await _context.TarifasDeOnibus.ToListAsync());
        }

        // GET: TarifasDeOnibus/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarifasDeOnibus = await _context.TarifasDeOnibus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tarifasDeOnibus == null)
            {
                return NotFound();
            }

            return View(tarifasDeOnibus);
        }

        // GET: TarifasDeOnibus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TarifasDeOnibus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,tarifa_original,tarifa_atual,tipo,data_modificacao")] TarifasDeOnibus tarifasDeOnibus)
        {
            if (ModelState.IsValid)
            {
                tarifasDeOnibus.Id = Guid.NewGuid();
                _context.Add(tarifasDeOnibus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tarifasDeOnibus);
        }

        // GET: TarifasDeOnibus/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarifasDeOnibus = await _context.TarifasDeOnibus.FindAsync(id);
            if (tarifasDeOnibus == null)
            {
                return NotFound();
            }
            return View(tarifasDeOnibus);
        }

        // POST: TarifasDeOnibus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,tarifa_original,tarifa_atual,tipo,data_modificacao")] TarifasDeOnibus tarifasDeOnibus)
        {
            if (id != tarifasDeOnibus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tarifasDeOnibus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TarifasDeOnibusExists(tarifasDeOnibus.Id))
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
            return View(tarifasDeOnibus);
        }

        // GET: TarifasDeOnibus/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarifasDeOnibus = await _context.TarifasDeOnibus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tarifasDeOnibus == null)
            {
                return NotFound();
            }

            return View(tarifasDeOnibus);
        }

        // POST: TarifasDeOnibus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tarifasDeOnibus = await _context.TarifasDeOnibus.FindAsync(id);
            _context.TarifasDeOnibus.Remove(tarifasDeOnibus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TarifasDeOnibusExists(Guid id)
        {
            return _context.TarifasDeOnibus.Any(e => e.Id == id);
        }
    }
}
