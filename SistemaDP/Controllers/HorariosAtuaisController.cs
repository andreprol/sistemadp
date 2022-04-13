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
    public class HorariosAtuaisController : Controller
    {
        private readonly SistemaDPContext _context;

        public HorariosAtuaisController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: HorariosAtuais
        public async Task<IActionResult> Index()
        {
            return View(await _context.HorariosAtuais.ToListAsync());
        }

        // GET: HorariosAtuais/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horariosAtuais = await _context.HorariosAtuais
                .FirstOrDefaultAsync(m => m.Id == id);
            if (horariosAtuais == null)
            {
                return NotFound();
            }

            return View(horariosAtuais);
        }

        // GET: HorariosAtuais/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HorariosAtuais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,data_entrada_abertura,data_saida_abertura,data_entrada_inter,data_saida_inter,data_entrada_noite,data_saida_noite")] HorariosAtuais horariosAtuais)
        {
            if (ModelState.IsValid)
            {
                horariosAtuais.Id = Guid.NewGuid();
                _context.Add(horariosAtuais);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(horariosAtuais);
        }

        // GET: HorariosAtuais/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horariosAtuais = await _context.HorariosAtuais.FindAsync(id);
            if (horariosAtuais == null)
            {
                return NotFound();
            }
            return View(horariosAtuais);
        }

        // POST: HorariosAtuais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,data_entrada_abertura,data_saida_abertura,data_entrada_inter,data_saida_inter,data_entrada_noite,data_saida_noite")] HorariosAtuais horariosAtuais)
        {
            if (id != horariosAtuais.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(horariosAtuais);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HorariosAtuaisExists(horariosAtuais.Id))
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
            return View(horariosAtuais);
        }

        // GET: HorariosAtuais/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horariosAtuais = await _context.HorariosAtuais
                .FirstOrDefaultAsync(m => m.Id == id);
            if (horariosAtuais == null)
            {
                return NotFound();
            }

            return View(horariosAtuais);
        }

        // POST: HorariosAtuais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var horariosAtuais = await _context.HorariosAtuais.FindAsync(id);
            _context.HorariosAtuais.Remove(horariosAtuais);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HorariosAtuaisExists(Guid id)
        {
            return _context.HorariosAtuais.Any(e => e.Id == id);
        }
    }
}
