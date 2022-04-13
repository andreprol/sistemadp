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
    public class MotivosAfastamentoesController : Controller
    {
        private readonly SistemaDPContext _context;

        public MotivosAfastamentoesController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: MotivosAfastamentoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.MotivosAfastamento.ToListAsync());
        }

        // GET: MotivosAfastamentoes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motivosAfastamento = await _context.MotivosAfastamento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (motivosAfastamento == null)
            {
                return NotFound();
            }

            return View(motivosAfastamento);
        }

        // GET: MotivosAfastamentoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MotivosAfastamentoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,descricao,data_afastamento")] MotivosAfastamento motivosAfastamento)
        {
            if (ModelState.IsValid)
            {
                motivosAfastamento.Id = Guid.NewGuid();
                _context.Add(motivosAfastamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motivosAfastamento);
        }

        // GET: MotivosAfastamentoes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motivosAfastamento = await _context.MotivosAfastamento.FindAsync(id);
            if (motivosAfastamento == null)
            {
                return NotFound();
            }
            return View(motivosAfastamento);
        }

        // POST: MotivosAfastamentoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,descricao,data_afastamento")] MotivosAfastamento motivosAfastamento)
        {
            if (id != motivosAfastamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motivosAfastamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotivosAfastamentoExists(motivosAfastamento.Id))
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
            return View(motivosAfastamento);
        }

        // GET: MotivosAfastamentoes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motivosAfastamento = await _context.MotivosAfastamento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (motivosAfastamento == null)
            {
                return NotFound();
            }

            return View(motivosAfastamento);
        }

        // POST: MotivosAfastamentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var motivosAfastamento = await _context.MotivosAfastamento.FindAsync(id);
            _context.MotivosAfastamento.Remove(motivosAfastamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotivosAfastamentoExists(Guid id)
        {
            return _context.MotivosAfastamento.Any(e => e.Id == id);
        }
    }
}
