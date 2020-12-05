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
    public class MemberReferenceController : Controller
    {
        private readonly TrackerContext _context;

        public MemberReferenceController(TrackerContext context)
        {
            _context = context;
        }

        // GET: MemberReference
        public async Task<IActionResult> Index()
        {
            var trackerContext = _context.MemberReference.Include(m => m.Member).Include(m => m.Reference);
            return View(await trackerContext.ToListAsync());
        }

        // GET: MemberReference/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberReference = await _context.MemberReference
                .Include(m => m.Member)
                .Include(m => m.Reference)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (memberReference == null)
            {
                return NotFound();
            }

            return View(memberReference);
        }

        // GET: MemberReference/Create
        public IActionResult Create()
        {
            ViewData["MemberID"] = new SelectList(_context.Membership, "ID", "name");
            ViewData["ReferenceID"] = new SelectList(_context.References, "ID", "ID");
            return View();
        }

        // POST: MemberReference/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MemberID,ReferenceID")] MemberReference memberReference)
        {
            if (ModelState.IsValid)
            {
                _context.Add(memberReference);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MemberID"] = new SelectList(_context.Membership, "ID", "name", memberReference.MemberID);
            ViewData["ReferenceID"] = new SelectList(_context.References, "ID", "ID", memberReference.ReferenceID);
            return View(memberReference);
        }

        // GET: MemberReference/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberReference = await _context.MemberReference.FindAsync(id);
            if (memberReference == null)
            {
                return NotFound();
            }
            ViewData["MemberID"] = new SelectList(_context.Membership, "ID", "name", memberReference.MemberID);
            ViewData["ReferenceID"] = new SelectList(_context.References, "ID", "ID", memberReference.ReferenceID);
            return View(memberReference);
        }

        // POST: MemberReference/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MemberID,ReferenceID")] MemberReference memberReference)
        {
            if (id != memberReference.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(memberReference);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberReferenceExists(memberReference.ID))
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
            ViewData["MemberID"] = new SelectList(_context.Membership, "ID", "name", memberReference.MemberID);
            ViewData["ReferenceID"] = new SelectList(_context.References, "ID", "ID", memberReference.ReferenceID);
            return View(memberReference);
        }

        // GET: MemberReference/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberReference = await _context.MemberReference
                .Include(m => m.Member)
                .Include(m => m.Reference)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (memberReference == null)
            {
                return NotFound();
            }

            return View(memberReference);
        }

        // POST: MemberReference/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var memberReference = await _context.MemberReference.FindAsync(id);
            _context.MemberReference.Remove(memberReference);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemberReferenceExists(int id)
        {
            return _context.MemberReference.Any(e => e.ID == id);
        }
    }
}
