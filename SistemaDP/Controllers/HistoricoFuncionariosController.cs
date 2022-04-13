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
    public class HistoricoFuncionariosController : Controller
    {
        private readonly SistemaDPContext _context;

        public HistoricoFuncionariosController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: HistoricoFuncionarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.HistoricoFuncionario.ToListAsync());
        }

        // GET: HistoricoFuncionarios/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoFuncionario = await _context.HistoricoFuncionario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicoFuncionario == null)
            {
                return NotFound();
            }

            return View(historicoFuncionario);
        }

        // GET: HistoricoFuncionarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HistoricoFuncionarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,data,descricao")] HistoricoFuncionario historicoFuncionario)
        {
            if (ModelState.IsValid)
            {
                historicoFuncionario.Id = Guid.NewGuid();
                _context.Add(historicoFuncionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(historicoFuncionario);
        }

        // GET: HistoricoFuncionarios/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoFuncionario = await _context.HistoricoFuncionario.FindAsync(id);
            if (historicoFuncionario == null)
            {
                return NotFound();
            }
            return View(historicoFuncionario);
        }

        // POST: HistoricoFuncionarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,data,descricao")] HistoricoFuncionario historicoFuncionario)
        {
            if (id != historicoFuncionario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historicoFuncionario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistoricoFuncionarioExists(historicoFuncionario.Id))
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
            return View(historicoFuncionario);
        }

        // GET: HistoricoFuncionarios/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoFuncionario = await _context.HistoricoFuncionario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicoFuncionario == null)
            {
                return NotFound();
            }

            return View(historicoFuncionario);
        }

        // POST: HistoricoFuncionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var historicoFuncionario = await _context.HistoricoFuncionario.FindAsync(id);
            _context.HistoricoFuncionario.Remove(historicoFuncionario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricoFuncionarioExists(Guid id)
        {
            return _context.HistoricoFuncionario.Any(e => e.Id == id);
        }
    }
}
