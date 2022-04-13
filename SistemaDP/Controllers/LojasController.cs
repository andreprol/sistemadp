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
    public class LojasController : Controller
    {
        private readonly SistemaDPContext _context;

        public LojasController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: Lojas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lojas.ToListAsync());
        }

        // GET: Lojas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lojas = await _context.Lojas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lojas == null)
            {
                return NotFound();
            }

            return View(lojas);
        }

        // GET: Lojas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lojas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,descricao,sigla,razao_social,cnpj,inscricao_estadual,cod_amil")] Lojas lojas)
        {
            if (ModelState.IsValid)
            {
                lojas.Id = Guid.NewGuid();
                _context.Add(lojas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lojas);
        }

        // GET: Lojas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lojas = await _context.Lojas.FindAsync(id);
            if (lojas == null)
            {
                return NotFound();
            }
            return View(lojas);
        }

        // POST: Lojas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,descricao,sigla,razao_social,cnpj,inscricao_estadual,cod_amil")] Lojas lojas)
        {
            if (id != lojas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lojas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LojasExists(lojas.Id))
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
            return View(lojas);
        }

        // GET: Lojas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lojas = await _context.Lojas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lojas == null)
            {
                return NotFound();
            }

            return View(lojas);
        }

        // POST: Lojas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var lojas = await _context.Lojas.FindAsync(id);
            _context.Lojas.Remove(lojas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LojasExists(Guid id)
        {
            return _context.Lojas.Any(e => e.Id == id);
        }
    }
}
