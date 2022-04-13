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
    public class UnidadeDeFederacaosController : Controller
    {
        private readonly SistemaDPContext _context;

        public UnidadeDeFederacaosController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: UnidadeDeFederacaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.UnidadeDeFederacao.ToListAsync());
        }

        // GET: UnidadeDeFederacaos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unidadeDeFederacao = await _context.UnidadeDeFederacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (unidadeDeFederacao == null)
            {
                return NotFound();
            }

            return View(unidadeDeFederacao);
        }

        // GET: UnidadeDeFederacaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UnidadeDeFederacaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,estado,sigla")] UnidadeDeFederacao unidadeDeFederacao)
        {
            if (ModelState.IsValid)
            {
                unidadeDeFederacao.Id = Guid.NewGuid();
                _context.Add(unidadeDeFederacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(unidadeDeFederacao);
        }

        // GET: UnidadeDeFederacaos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unidadeDeFederacao = await _context.UnidadeDeFederacao.FindAsync(id);
            if (unidadeDeFederacao == null)
            {
                return NotFound();
            }
            return View(unidadeDeFederacao);
        }

        // POST: UnidadeDeFederacaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,estado,sigla")] UnidadeDeFederacao unidadeDeFederacao)
        {
            if (id != unidadeDeFederacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unidadeDeFederacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnidadeDeFederacaoExists(unidadeDeFederacao.Id))
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
            return View(unidadeDeFederacao);
        }

        // GET: UnidadeDeFederacaos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unidadeDeFederacao = await _context.UnidadeDeFederacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (unidadeDeFederacao == null)
            {
                return NotFound();
            }

            return View(unidadeDeFederacao);
        }

        // POST: UnidadeDeFederacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var unidadeDeFederacao = await _context.UnidadeDeFederacao.FindAsync(id);
            _context.UnidadeDeFederacao.Remove(unidadeDeFederacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnidadeDeFederacaoExists(Guid id)
        {
            return _context.UnidadeDeFederacao.Any(e => e.Id == id);
        }
    }
}
