using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrklPPR.Data;
using TrklPPR.Models;

namespace TrklPPR
{
    public class AdminDiscoversController : Controller
    {
        private readonly TrklPPRContext _context;

        public AdminDiscoversController(TrklPPRContext context)
        {
            _context = context;
        }

        // GET: AdminDiscovers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Discovers.ToListAsync());
        }

        // GET: AdminDiscovers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Discovers = await _context.Discovers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Discovers == null)
            {
                return NotFound();
            }

            return View(Discovers);
        }

        // GET: AdminDiscovers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminDiscovers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Price")] Discover Discovers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Discovers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Discovers);
        }

        // GET: AdminDiscovers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Discover = await _context.Discovers.FindAsync(id);
            if (Discover == null)
            {
                return NotFound();
            }
            return View(Discover);
        }

        // POST: AdminDiscovers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Price")] Discover Discovers)
        {
            if (id != Discovers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Discovers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiscoversExists(Discovers.Id))
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
            return View(Discovers);
        }

        // GET: AdminDiscovers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Discovers = await _context.Discovers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Discovers == null)
            {
                return NotFound();
            }

            return View(Discovers);
        }

        // POST: AdminDiscovers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Discovers = await _context.Discovers.FindAsync(id);
            if (Discovers != null)
            {
                _context.Discovers.Remove(Discovers);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiscoversExists(int id)
        {
            return _context.Discovers.Any(e => e.Id == id);
        }
    }
}
