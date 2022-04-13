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
    public class EnderecoFuncionariosController : Controller
    {
        private readonly SistemaDPContext _context;

        public EnderecoFuncionariosController(SistemaDPContext context)
        {
            _context = context;
        }

        // GET: EnderecoFuncionarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.EnderecoFuncionario.ToListAsync());
        }

        // GET: EnderecoFuncionarios/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enderecoFuncionario = await _context.EnderecoFuncionario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enderecoFuncionario == null)
            {
                return NotFound();
            }

            return View(enderecoFuncionario);
        }

        // GET: EnderecoFuncionarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EnderecoFuncionarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,rua,numero,complemento,bairro,cidade,telefone")] EnderecoFuncionario enderecoFuncionario)
        {
            if (ModelState.IsValid)
            {
                enderecoFuncionario.Id = Guid.NewGuid();
                _context.Add(enderecoFuncionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enderecoFuncionario);
        }

        // GET: EnderecoFuncionarios/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enderecoFuncionario = await _context.EnderecoFuncionario.FindAsync(id);
            if (enderecoFuncionario == null)
            {
                return NotFound();
            }
            return View(enderecoFuncionario);
        }

        // POST: EnderecoFuncionarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,rua,numero,complemento,bairro,cidade,telefone")] EnderecoFuncionario enderecoFuncionario)
        {
            if (id != enderecoFuncionario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enderecoFuncionario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnderecoFuncionarioExists(enderecoFuncionario.Id))
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
            return View(enderecoFuncionario);
        }

        // GET: EnderecoFuncionarios/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enderecoFuncionario = await _context.EnderecoFuncionario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enderecoFuncionario == null)
            {
                return NotFound();
            }

            return View(enderecoFuncionario);
        }

        // POST: EnderecoFuncionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var enderecoFuncionario = await _context.EnderecoFuncionario.FindAsync(id);
            _context.EnderecoFuncionario.Remove(enderecoFuncionario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnderecoFuncionarioExists(Guid id)
        {
            return _context.EnderecoFuncionario.Any(e => e.Id == id);
        }
    }
}
