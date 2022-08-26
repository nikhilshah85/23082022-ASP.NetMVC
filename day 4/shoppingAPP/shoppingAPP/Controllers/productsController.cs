using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using shoppingAPP.Models.EF;

namespace shoppingAPP.Controllers
{
    public class productsController : Controller
    {
        private readonly shoppingAPPDBContext _context = new shoppingAPPDBContext();

     

        // GET: products
        public async Task<IActionResult> Index()
        {
              return _context.ProductsLists != null ? 
                          View(await _context.ProductsLists.ToListAsync()) :
                          Problem("Entity set 'shoppingAPPDBContext.ProductsLists'  is null.");
        }

        // GET: products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProductsLists == null)
            {
                return NotFound();
            }

            var productsList = await _context.ProductsLists
                .FirstOrDefaultAsync(m => m.PId == id);
            if (productsList == null)
            {
                return NotFound();
            }

            return View(productsList);
        }

        // GET: products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PId,PName,PCategory,PPrice,PIsInStock")] ProductsList productsList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productsList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productsList);
        }

        // GET: products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProductsLists == null)
            {
                return NotFound();
            }

            var productsList = await _context.ProductsLists.FindAsync(id);
            if (productsList == null)
            {
                return NotFound();
            }
            return View(productsList);
        }

        // POST: products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PId,PName,PCategory,PPrice,PIsInStock")] ProductsList productsList)
        {
            if (id != productsList.PId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productsList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsListExists(productsList.PId))
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
            return View(productsList);
        }

        // GET: products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProductsLists == null)
            {
                return NotFound();
            }

            var productsList = await _context.ProductsLists
                .FirstOrDefaultAsync(m => m.PId == id);
            if (productsList == null)
            {
                return NotFound();
            }

            return View(productsList);
        }

        // POST: products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProductsLists == null)
            {
                return Problem("Entity set 'shoppingAPPDBContext.ProductsLists'  is null.");
            }
            var productsList = await _context.ProductsLists.FindAsync(id);
            if (productsList != null)
            {
                _context.ProductsLists.Remove(productsList);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsListExists(int id)
        {
          return (_context.ProductsLists?.Any(e => e.PId == id)).GetValueOrDefault();
        }
    }
}
