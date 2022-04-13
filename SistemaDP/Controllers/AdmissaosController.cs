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
    public class AdmissaosController : Controller
    {
        private readonly SistemaDPContext _context;

        public AdmissaosController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: Admissaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Admissao.ToListAsync());
        }

        // GET: Admissaos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admissao = await _context.Admissao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admissao == null)
            {
                return NotFound();
            }

            return View(admissao);
        }

        // GET: Admissaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admissaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,tipo,data_admissao")] Admissao admissao)
        {
            if (ModelState.IsValid)
            {
                admissao.Id = Guid.NewGuid();
                _context.Add(admissao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(admissao);
        }

        // GET: Admissaos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admissao = await _context.Admissao.FindAsync(id);
            if (admissao == null)
            {
                return NotFound();
            }
            return View(admissao);
        }

        // POST: Admissaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,tipo,data_admissao")] Admissao admissao)
        {
            if (id != admissao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admissao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmissaoExists(admissao.Id))
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
            return View(admissao);
        }

        // GET: Admissaos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admissao = await _context.Admissao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admissao == null)
            {
                return NotFound();
            }

            return View(admissao);
        }

        // POST: Admissaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var admissao = await _context.Admissao.FindAsync(id);
            _context.Admissao.Remove(admissao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdmissaoExists(Guid id)
        {
            return _context.Admissao.Any(e => e.Id == id);
        }
    }
}
