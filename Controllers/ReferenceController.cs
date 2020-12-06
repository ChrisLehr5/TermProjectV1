using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TermProjectV1.Models;

namespace TermProjectV1.Controllers
{
    public class ReferenceController : Controller
    {
        private readonly TrackerContext _context;

        public ReferenceController(TrackerContext context)
        {
            _context = context;
        }

        // GET: Reference
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {

            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParam"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";         

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;


            var reference = from e in _context.References select e;

            if (!String.IsNullOrEmpty(searchString))
            {
                reference = reference.Where(s => s.LastName.Contains(searchString)
                     || s.Name.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    reference = reference.OrderByDescending(s => s.LastName);
                    break;               
                default:
                    reference.OrderBy(s => s.LastName);
                    break;
            }
            int pageSize = 2;
            return View(await PaginatedList<Reference>.CreateAsync(reference.AsNoTracking(), pageNumber ?? 1, pageSize));

        }

        // GET: Reference/Details/5
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reference = await _context.References
                .FirstOrDefaultAsync(m => m.ID == id);
            if (reference == null)
            {
                return NotFound();
            }

            return View(reference);
        }

        // GET: Reference/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reference/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> Create([Bind("ReferenceId,Name,ID")] Reference reference)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reference);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reference);
        }

        // GET: Reference/Edit/5
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reference = await _context.References.FindAsync(id);
            if (reference == null)
            {
                return NotFound();
            }
            return View(reference);
        }

        // POST: Reference/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> Edit(int id, [Bind("ReferenceId,Name,ID")] Reference reference)
        {
            if (id != reference.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reference);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReferenceExists(reference.ID))
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
            return View(reference);
        }

        // GET: Reference/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reference = await _context.References
                .FirstOrDefaultAsync(m => m.ID == id);
            if (reference == null)
            {
                return NotFound();
            }

            return View(reference);
        }

        // POST: Reference/Delete/5
        [Authorize(Roles = "Administrator")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reference = await _context.References.FindAsync(id);
            _context.References.Remove(reference);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReferenceExists(int id)
        {
            return _context.References.Any(e => e.ID == id);
        }
    }
}
