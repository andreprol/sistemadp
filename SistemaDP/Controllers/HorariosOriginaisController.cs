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
    public class HorariosOriginaisController : Controller
    {
        private readonly SistemaDPContext _context;

        public HorariosOriginaisController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: HorariosOriginais
        public async Task<IActionResult> Index()
        {
            return View(await _context.HorariosOriginais.ToListAsync());
        }

        // GET: HorariosOriginais/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horariosOriginais = await _context.HorariosOriginais
                .FirstOrDefaultAsync(m => m.Id == id);
            if (horariosOriginais == null)
            {
                return NotFound();
            }

            return View(horariosOriginais);
        }

        // GET: HorariosOriginais/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HorariosOriginais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,data_entrada_abertura,data_saida_abertura,data_entrada_inter,data_saida_inter,data_entrada_noite,data_saida_noite")] HorariosOriginais horariosOriginais)
        {
            if (ModelState.IsValid)
            {
                horariosOriginais.Id = Guid.NewGuid();
                _context.Add(horariosOriginais);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(horariosOriginais);
        }

        // GET: HorariosOriginais/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horariosOriginais = await _context.HorariosOriginais.FindAsync(id);
            if (horariosOriginais == null)
            {
                return NotFound();
            }
            return View(horariosOriginais);
        }

        // POST: HorariosOriginais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,data_entrada_abertura,data_saida_abertura,data_entrada_inter,data_saida_inter,data_entrada_noite,data_saida_noite")] HorariosOriginais horariosOriginais)
        {
            if (id != horariosOriginais.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(horariosOriginais);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HorariosOriginaisExists(horariosOriginais.Id))
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
            return View(horariosOriginais);
        }

        // GET: HorariosOriginais/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horariosOriginais = await _context.HorariosOriginais
                .FirstOrDefaultAsync(m => m.Id == id);
            if (horariosOriginais == null)
            {
                return NotFound();
            }

            return View(horariosOriginais);
        }

        // POST: HorariosOriginais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var horariosOriginais = await _context.HorariosOriginais.FindAsync(id);
            _context.HorariosOriginais.Remove(horariosOriginais);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HorariosOriginaisExists(Guid id)
        {
            return _context.HorariosOriginais.Any(e => e.Id == id);
        }
    }
}
