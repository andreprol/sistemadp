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
    public class DivisaosController : Controller
    {
        private readonly SistemaDPContext _context;

        public DivisaosController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: Divisaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Divisao.ToListAsync());
        }

        // GET: Divisaos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divisao = await _context.Divisao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (divisao == null)
            {
                return NotFound();
            }

            return View(divisao);
        }

        // GET: Divisaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Divisaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,numero_divisao,descricao")] Divisao divisao)
        {
            if (ModelState.IsValid)
            {
                divisao.Id = Guid.NewGuid();
                _context.Add(divisao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(divisao);
        }

        // GET: Divisaos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divisao = await _context.Divisao.FindAsync(id);
            if (divisao == null)
            {
                return NotFound();
            }
            return View(divisao);
        }

        // POST: Divisaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,numero_divisao,descricao")] Divisao divisao)
        {
            if (id != divisao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(divisao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DivisaoExists(divisao.Id))
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
            return View(divisao);
        }

        // GET: Divisaos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divisao = await _context.Divisao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (divisao == null)
            {
                return NotFound();
            }

            return View(divisao);
        }

        // POST: Divisaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var divisao = await _context.Divisao.FindAsync(id);
            _context.Divisao.Remove(divisao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DivisaoExists(Guid id)
        {
            return _context.Divisao.Any(e => e.Id == id);
        }
    }
}
