using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaDeEmprestimos.Data;
using SistemaDeEmprestimos.Models;
using System.Text.Json;

namespace SistemaDeEmprestimos.Controllers
{
    public class ParcelasController : Controller
    {
        private readonly SistemaDeEmprestimosContext _context;

        public ParcelasController(SistemaDeEmprestimosContext context)
        {
            _context = context;
        }

        // GET: Parcelas
        public async Task<IActionResult> Index()
        {
            var sistemaDeEmprestimosContext = _context.Parcela.Include(p => p.Emprestimo);
            return View(await sistemaDeEmprestimosContext.ToListAsync());
        }

        // GET: Parcelas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parcela = await _context.Parcela
                .Include(p => p.Emprestimo)
                .FirstOrDefaultAsync(m => m.ParcelaId == id);
            if (parcela == null)
            {
                return NotFound();
            }

            return View(parcela);
        }

        // GET: Parcelas/Create
        public IActionResult Create()
        {
            ViewData["EmprestimoId"] = new SelectList(_context.Emprestimo, "EmprestimoId", "EmprestimoId");
            return View();
        }

        // POST: Parcelas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParcelaId,EmprestimoId,ValorParcela,NumeroParcela,Pago")] Parcela parcela)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parcela);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmprestimoId"] = new SelectList(_context.Emprestimo, "EmprestimoId", "EmprestimoId", parcela.EmprestimoId);
            return View(parcela);
        }

        public async Task<IActionResult> CreateParcela() {
            var model = TempData["Parcela"];
            _context.Add(model);
            await _context.SaveChangesAsync();
            return View("Index");
        }

        // GET: Parcelas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parcela = await _context.Parcela.FindAsync(id);
            if (parcela == null)
            {
                return NotFound();
            }
            ViewData["EmprestimoId"] = new SelectList(_context.Emprestimo, "EmprestimoId", "EmprestimoId", parcela.EmprestimoId);
            return View(parcela);
        }

        // POST: Parcelas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ParcelaId,EmprestimoId,ValorParcela,NumeroParcela,Pago")] Parcela parcela)
        {
            if (id != parcela.ParcelaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parcela);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParcelaExists(parcela.ParcelaId))
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
            ViewData["EmprestimoId"] = new SelectList(_context.Emprestimo, "EmprestimoId", "EmprestimoId", parcela.EmprestimoId);
            return View(parcela);
        }

        // GET: Parcelas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parcela = await _context.Parcela
                .Include(p => p.Emprestimo)
                .FirstOrDefaultAsync(m => m.ParcelaId == id);
            if (parcela == null)
            {
                return NotFound();
            }

            return View(parcela);
        }

        // POST: Parcelas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parcela = await _context.Parcela.FindAsync(id);
            _context.Parcela.Remove(parcela);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParcelaExists(int id)
        {
            return _context.Parcela.Any(e => e.ParcelaId == id);
        }
    }
}
