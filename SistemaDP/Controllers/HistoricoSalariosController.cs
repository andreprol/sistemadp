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
    public class HistoricoSalariosController : Controller
    {
        private readonly SistemaDPContext _context;

        public HistoricoSalariosController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: HistoricoSalarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.HistoricoSalario.ToListAsync());
        }

        // GET: HistoricoSalarios/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoSalario = await _context.HistoricoSalario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicoSalario == null)
            {
                return NotFound();
            }

            return View(historicoSalario);
        }

        // GET: HistoricoSalarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HistoricoSalarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,data_mod_salario,salario_inicial,salario_atual")] HistoricoSalario historicoSalario)
        {
            if (ModelState.IsValid)
            {
                historicoSalario.Id = Guid.NewGuid();
                _context.Add(historicoSalario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(historicoSalario);
        }

        // GET: HistoricoSalarios/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoSalario = await _context.HistoricoSalario.FindAsync(id);
            if (historicoSalario == null)
            {
                return NotFound();
            }
            return View(historicoSalario);
        }

        // POST: HistoricoSalarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,data_mod_salario,salario_inicial,salario_atual")] HistoricoSalario historicoSalario)
        {
            if (id != historicoSalario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historicoSalario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistoricoSalarioExists(historicoSalario.Id))
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
            return View(historicoSalario);
        }

        // GET: HistoricoSalarios/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoSalario = await _context.HistoricoSalario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicoSalario == null)
            {
                return NotFound();
            }

            return View(historicoSalario);
        }

        // POST: HistoricoSalarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var historicoSalario = await _context.HistoricoSalario.FindAsync(id);
            _context.HistoricoSalario.Remove(historicoSalario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricoSalarioExists(Guid id)
        {
            return _context.HistoricoSalario.Any(e => e.Id == id);
        }
    }
}
