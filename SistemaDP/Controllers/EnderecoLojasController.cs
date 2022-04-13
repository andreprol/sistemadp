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
    public class EnderecoLojasController : Controller
    {
        private readonly SistemaDPContext _context;

        public EnderecoLojasController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: EnderecoLojas
        public async Task<IActionResult> Index()
        {
            return View(await _context.EnderecoLojas.ToListAsync());
        }

        // GET: EnderecoLojas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enderecoLojas = await _context.EnderecoLojas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enderecoLojas == null)
            {
                return NotFound();
            }

            return View(enderecoLojas);
        }

        // GET: EnderecoLojas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EnderecoLojas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,rua,numero,complemento,bairro,cidade,telefone")] EnderecoLojas enderecoLojas)
        {
            if (ModelState.IsValid)
            {
                enderecoLojas.Id = Guid.NewGuid();
                _context.Add(enderecoLojas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enderecoLojas);
        }

        // GET: EnderecoLojas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enderecoLojas = await _context.EnderecoLojas.FindAsync(id);
            if (enderecoLojas == null)
            {
                return NotFound();
            }
            return View(enderecoLojas);
        }

        // POST: EnderecoLojas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,rua,numero,complemento,bairro,cidade,telefone")] EnderecoLojas enderecoLojas)
        {
            if (id != enderecoLojas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enderecoLojas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnderecoLojasExists(enderecoLojas.Id))
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
            return View(enderecoLojas);
        }

        // GET: EnderecoLojas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enderecoLojas = await _context.EnderecoLojas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enderecoLojas == null)
            {
                return NotFound();
            }

            return View(enderecoLojas);
        }

        // POST: EnderecoLojas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var enderecoLojas = await _context.EnderecoLojas.FindAsync(id);
            _context.EnderecoLojas.Remove(enderecoLojas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnderecoLojasExists(Guid id)
        {
            return _context.EnderecoLojas.Any(e => e.Id == id);
        }
    }
}
