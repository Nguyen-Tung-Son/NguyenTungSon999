using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenTungSon999.Data;
using NguyenTungSon999.Models;

namespace NguyenTungSon999.Controllers
{
    public class UniversityNTS999Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public UniversityNTS999Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UniversityNTS999
        public async Task<IActionResult> Index()
        {
              return _context.UniversityNTS999 != null ? 
                          View(await _context.UniversityNTS999.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.UniversityNTS999'  is null.");
        }

        // GET: UniversityNTS999/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.UniversityNTS999 == null)
            {
                return NotFound();
            }

            var universityNTS999 = await _context.UniversityNTS999
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNTS999 == null)
            {
                return NotFound();
            }

            return View(universityNTS999);
        }

        // GET: UniversityNTS999/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityNTS999/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityNTS999 universityNTS999)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityNTS999);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityNTS999);
        }

        // GET: UniversityNTS999/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.UniversityNTS999 == null)
            {
                return NotFound();
            }

            var universityNTS999 = await _context.UniversityNTS999.FindAsync(id);
            if (universityNTS999 == null)
            {
                return NotFound();
            }
            return View(universityNTS999);
        }

        // POST: UniversityNTS999/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityNTS999 universityNTS999)
        {
            if (id != universityNTS999.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityNTS999);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityNTS999Exists(universityNTS999.UniversityId))
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
            return View(universityNTS999);
        }

        // GET: UniversityNTS999/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.UniversityNTS999 == null)
            {
                return NotFound();
            }

            var universityNTS999 = await _context.UniversityNTS999
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNTS999 == null)
            {
                return NotFound();
            }

            return View(universityNTS999);
        }

        // POST: UniversityNTS999/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.UniversityNTS999 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.UniversityNTS999'  is null.");
            }
            var universityNTS999 = await _context.UniversityNTS999.FindAsync(id);
            if (universityNTS999 != null)
            {
                _context.UniversityNTS999.Remove(universityNTS999);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityNTS999Exists(string id)
        {
          return (_context.UniversityNTS999?.Any(e => e.UniversityId == id)).GetValueOrDefault();
        }
    }
}
