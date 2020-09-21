using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TermProjectV1.Models;

namespace TermProjectV1.Controllers
{
    public class DetailController : Controller
    {
        private readonly TrackerContext _context;

        public DetailController(TrackerContext context)
        {
            _context = context;
        }

        // GET: Detail
        public async Task<IActionResult> Index()
        {
            var trackerContext = _context.Statistics.Include(d => d.Member);
            return View(await trackerContext.ToListAsync());
        }

        // GET: Detail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var details = await _context.Statistics
                .Include(d => d.Member)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (details == null)
            {
                return NotFound();
            }

            return View(details);
        }

        // GET: Detail/Create
        public IActionResult Create()
        {
            ViewData["MemberID"] = new SelectList(_context.Membership, "ID", "name");
            return View();
        }

        // POST: Detail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,detailDate,age,MemberID")] Details details)
        {
            if (ModelState.IsValid)
            {
                _context.Add(details);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MemberID"] = new SelectList(_context.Membership, "ID", "name", details.MemberID);
            return View(details);
        }

        // GET: Detail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var details = await _context.Statistics.FindAsync(id);
            if (details == null)
            {
                return NotFound();
            }
            ViewData["MemberID"] = new SelectList(_context.Membership, "ID", "name", details.MemberID);
            return View(details);
        }

        // POST: Detail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,detailDate,age,MemberID")] Details details)
        {
            if (id != details.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(details);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetailsExists(details.ID))
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
            ViewData["MemberID"] = new SelectList(_context.Membership, "ID", "name", details.MemberID);
            return View(details);
        }

        // GET: Detail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var details = await _context.Statistics
                .Include(d => d.Member)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (details == null)
            {
                return NotFound();
            }

            return View(details);
        }

        // POST: Detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var details = await _context.Statistics.FindAsync(id);
            _context.Statistics.Remove(details);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetailsExists(int id)
        {
            return _context.Statistics.Any(e => e.ID == id);
        }
    }
}
