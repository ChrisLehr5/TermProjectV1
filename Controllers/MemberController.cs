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
    public class MemberController : Controller
    {
        private readonly TrackerContext _context;

        public MemberController(TrackerContext context)
        {
            _context = context;
        }

        // GET: Member
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParam"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParam"] = sortOrder == "Zip" ? "zip_desc" : "Zip";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;


            var member = from e in _context.Membership select e;

            if (!String.IsNullOrEmpty(searchString))
            {
               member = member.Where(s => s.LastName.Contains(searchString)
                    || s.name.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    member = member.OrderByDescending(s => s.LastName);
                    break;
                case "Zip":
                    member = member.OrderBy(s => s.zip);
                    break;
                case "date_desc":
                    member = member.OrderByDescending(s => s.zip);
                    break;
                default:
                    member.OrderBy(s => s.LastName);
                    break;
            }
            int pageSize = 5;
            return View(await PaginatedList<Member>.CreateAsync(member.AsNoTracking(), pageNumber ?? 1, pageSize));
        }


        // GET: Member/Details/5
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Membership
                .FirstOrDefaultAsync(m => m.ID == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // GET: Member/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Member/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> Create([Bind("ID,name,LastName,gender,address,city,state,zip,email,cell")] Member member)
        {
            if (ModelState.IsValid)
            {
                _context.Add(member);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        // GET: Member/Edit/5
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Membership.FindAsync(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: Member/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,name,LastName,gender,address,city,state,zip,email,cell")] Member member)
        {
            if (id != member.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(member);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(member.ID))
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
            return View(member);
        }

        // GET: Member/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Membership
                .FirstOrDefaultAsync(m => m.ID == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // POST: Member/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var member = await _context.Membership.FindAsync(id);
            _context.Membership.Remove(member);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemberExists(int id)
        {
            return _context.Membership.Any(e => e.ID == id);
        }
    }
}
