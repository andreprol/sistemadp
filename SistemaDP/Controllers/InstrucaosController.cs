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
    public class InstrucaosController : Controller
    {
        private readonly SistemaDPContext _context;

        public InstrucaosController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: Instrucaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Instrucao.ToListAsync());
        }

        // GET: Instrucaos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instrucao = await _context.Instrucao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (instrucao == null)
            {
                return NotFound();
            }

            return View(instrucao);
        }

        // GET: Instrucaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Instrucaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,descricao")] Instrucao instrucao)
        {
            if (ModelState.IsValid)
            {
                instrucao.Id = Guid.NewGuid();
                _context.Add(instrucao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(instrucao);
        }

        // GET: Instrucaos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instrucao = await _context.Instrucao.FindAsync(id);
            if (instrucao == null)
            {
                return NotFound();
            }
            return View(instrucao);
        }

        // POST: Instrucaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,descricao")] Instrucao instrucao)
        {
            if (id != instrucao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instrucao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstrucaoExists(instrucao.Id))
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
            return View(instrucao);
        }

        // GET: Instrucaos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instrucao = await _context.Instrucao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (instrucao == null)
            {
                return NotFound();
            }

            return View(instrucao);
        }

        // POST: Instrucaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var instrucao = await _context.Instrucao.FindAsync(id);
            _context.Instrucao.Remove(instrucao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstrucaoExists(Guid id)
        {
            return _context.Instrucao.Any(e => e.Id == id);
        }
    }
}
