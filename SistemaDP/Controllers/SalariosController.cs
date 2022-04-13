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
    public class SalariosController : Controller
    {
        private readonly SistemaDPContext _context;

        public SalariosController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: Salarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Salarios.ToListAsync());
        }

        // GET: Salarios/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salarios = await _context.Salarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salarios == null)
            {
                return NotFound();
            }

            return View(salarios);
        }

        // GET: Salarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Salarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,cargo_original,cargo_atual,salario_original,salario_atual,data_modificao")] Salarios salarios)
        {
            if (ModelState.IsValid)
            {
                salarios.Id = Guid.NewGuid();
                _context.Add(salarios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salarios);
        }

        // GET: Salarios/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salarios = await _context.Salarios.FindAsync(id);
            if (salarios == null)
            {
                return NotFound();
            }
            return View(salarios);
        }

        // POST: Salarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,cargo_original,cargo_atual,salario_original,salario_atual,data_modificao")] Salarios salarios)
        {
            if (id != salarios.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salarios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalariosExists(salarios.Id))
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
            return View(salarios);
        }

        // GET: Salarios/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salarios = await _context.Salarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salarios == null)
            {
                return NotFound();
            }

            return View(salarios);
        }

        // POST: Salarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var salarios = await _context.Salarios.FindAsync(id);
            _context.Salarios.Remove(salarios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalariosExists(Guid id)
        {
            return _context.Salarios.Any(e => e.Id == id);
        }
    }
}
