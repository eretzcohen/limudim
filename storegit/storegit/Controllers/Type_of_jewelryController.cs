using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using storegit.Models;

namespace storegit.Controllers
{
    public class Type_of_jewelryController : Controller
    {
        private readonly shopeContext _context;

        public Type_of_jewelryController(shopeContext context)
        {
            _context = context;
        }

        // GET: Type_of_jewelry
        public async Task<IActionResult> Index()
        {
            return View(await _context.Type_of_jewelry.ToListAsync());
        }

        // GET: Type_of_jewelry/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var type_of_jewelry = await _context.Type_of_jewelry
                .SingleOrDefaultAsync(m => m.id == id);
            if (type_of_jewelry == null)
            {
                return NotFound();
            }

            return View(type_of_jewelry);
        }

        // GET: Type_of_jewelry/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Type_of_jewelry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name")] Type_of_jewelry type_of_jewelry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(type_of_jewelry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(type_of_jewelry);
        }

        // GET: Type_of_jewelry/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var type_of_jewelry = await _context.Type_of_jewelry.SingleOrDefaultAsync(m => m.id == id);
            if (type_of_jewelry == null)
            {
                return NotFound();
            }
            return View(type_of_jewelry);
        }

        // POST: Type_of_jewelry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name")] Type_of_jewelry type_of_jewelry)
        {
            if (id != type_of_jewelry.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(type_of_jewelry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Type_of_jewelryExists(type_of_jewelry.id))
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
            return View(type_of_jewelry);
        }

        // GET: Type_of_jewelry/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var type_of_jewelry = await _context.Type_of_jewelry
                .SingleOrDefaultAsync(m => m.id == id);
            if (type_of_jewelry == null)
            {
                return NotFound();
            }

            return View(type_of_jewelry);
        }

        // POST: Type_of_jewelry/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var type_of_jewelry = await _context.Type_of_jewelry.SingleOrDefaultAsync(m => m.id == id);
            _context.Type_of_jewelry.Remove(type_of_jewelry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Type_of_jewelryExists(int id)
        {
            return _context.Type_of_jewelry.Any(e => e.id == id);
        }
    }
}
