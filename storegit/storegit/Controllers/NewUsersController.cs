﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using storegit.Models;

namespace storegit.Controllers
{
    public class NewUsersController : Controller
    {
        private readonly shopeContext _context;

        public NewUsersController(shopeContext context)
        {
            _context = context;
        }

        // GET: NewUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.NewUser.ToListAsync());
        }

        // GET: NewUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newUser = await _context.NewUser
                .SingleOrDefaultAsync(m => m.id == id);
            if (newUser == null)
            {
                return NotFound();
            }

            return View(newUser);
        }

        // GET: NewUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NewUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,phone,email")] NewUser newUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(newUser);
        }

        // GET: NewUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newUser = await _context.NewUser.SingleOrDefaultAsync(m => m.id == id);
            if (newUser == null)
            {
                return NotFound();
            }
            return View(newUser);
        }

        // POST: NewUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,phone,email")] NewUser newUser)
        {
            if (id != newUser.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewUserExists(newUser.id))
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
            return View(newUser);
        }

        // GET: NewUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newUser = await _context.NewUser
                .SingleOrDefaultAsync(m => m.id == id);
            if (newUser == null)
            {
                return NotFound();
            }

            return View(newUser);
        }

        // POST: NewUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var newUser = await _context.NewUser.SingleOrDefaultAsync(m => m.id == id);
            _context.NewUser.Remove(newUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewUserExists(int id)
        {
            return _context.NewUser.Any(e => e.id == id);
        }
    }
}
