using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CSD412ProjectGroup00000100.Data;
using CSD412ProjectGroup00000100.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace CSD412ProjectGroup00000100.Controllers
{
    [Authorize]
    public class PollsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PollsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Polls
        public async Task<IActionResult> Index()
        {
            ApplicationUser theUser = await _userManager.GetUserAsync(User);
            IQueryable<Poll> applicationDbContext = _context.Polls.Include(p => p.User).Where(r => r.User == theUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Polls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poll = await _context.Polls
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.PollId == id);
            if (poll == null)
            {
                return NotFound();
            }

            return View(poll);
        }

        // GET: Polls/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id");
            return View();
        }

        // POST: Polls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description")] Poll poll)
        {
            if (ModelState.IsValid)
            {
                poll.User = await _userManager.GetUserAsync(User);
                poll.State = false;
                _context.Add(poll);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", poll.UserId);
            return View(poll);
        }

        // GET: Polls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poll = await _context.Polls.FindAsync(id);
            if (poll == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", poll.UserId);
            return View(poll);
        }

        // POST: Polls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PollId,UserId,Name,Description,State")] Poll poll)
        {
            if (id != poll.PollId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(poll);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PollExists(poll.PollId))
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
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", poll.UserId);
            return View(poll);
        }

        // GET: Polls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poll = await _context.Polls
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.PollId == id);
            if (poll == null)
            {
                return NotFound();
            }

            return View(poll);
        }

        // POST: Polls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var poll = await _context.Polls.FindAsync(id);
            _context.Polls.Remove(poll);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PollExists(int id)
        {
            return _context.Polls.Any(e => e.PollId == id);
        }
    }
}
