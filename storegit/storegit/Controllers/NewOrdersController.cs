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
    public class NewOrdersController : Controller
    {
        private readonly shopeContext _context;

        public NewOrdersController(shopeContext context)
        {
            _context = context;
        }

        // GET: NewOrders
        public async Task<IActionResult> Index()
        {
            return View(await _context.NewOrder.ToListAsync());
        }

        // GET: NewOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newOrder = await _context.NewOrder
                .SingleOrDefaultAsync(m => m.Id == id);
            if (newOrder == null)
            {
                return NotFound();
            }

            return View(newOrder);
        }

        // GET: NewOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NewOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data")] NewOrder newOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(newOrder);
        }

        // GET: NewOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newOrder = await _context.NewOrder.SingleOrDefaultAsync(m => m.Id == id);
            if (newOrder == null)
            {
                return NotFound();
            }
            return View(newOrder);
        }

        // POST: NewOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Data")] NewOrder newOrder)
        {
            if (id != newOrder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewOrderExists(newOrder.Id))
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
            return View(newOrder);
        }

        // GET: NewOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newOrder = await _context.NewOrder
                .SingleOrDefaultAsync(m => m.Id == id);
            if (newOrder == null)
            {
                return NotFound();
            }

            return View(newOrder);
        }

        // POST: NewOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var newOrder = await _context.NewOrder.SingleOrDefaultAsync(m => m.Id == id);
            _context.NewOrder.Remove(newOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewOrderExists(int id)
        {
            return _context.NewOrder.Any(e => e.Id == id);
        }
    }
}
