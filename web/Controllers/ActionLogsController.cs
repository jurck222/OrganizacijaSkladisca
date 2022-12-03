using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web.Data;
using web.Models;
using Microsoft.AspNetCore.Authorization;

namespace web.Controllers
{
    [Authorize]
    public class ActionLogsController : Controller
    {
        private readonly WarehouseContext _context;

        public ActionLogsController(WarehouseContext context)
        {
            _context = context;
        }

        // GET: ActionLogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ActionLogs.ToListAsync());
        }

        // GET: ActionLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ActionLogs == null)
            {
                return NotFound();
            }

            var actionLog = await _context.ActionLogs
                .FirstOrDefaultAsync(m => m.ActionLogID == id);
            if (actionLog == null)
            {
                return NotFound();
            }

            return View(actionLog);
        }

        // GET: ActionLogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ActionLogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ActionLogID,Code,Quantity")] ActionLog actionLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actionLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(actionLog);
        }

        // GET: ActionLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ActionLogs == null)
            {
                return NotFound();
            }

            var actionLog = await _context.ActionLogs.FindAsync(id);
            if (actionLog == null)
            {
                return NotFound();
            }
            return View(actionLog);
        }

        // POST: ActionLogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ActionLogID,Code,Quantity")] ActionLog actionLog)
        {
            if (id != actionLog.ActionLogID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actionLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActionLogExists(actionLog.ActionLogID))
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
            return View(actionLog);
        }

        // GET: ActionLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ActionLogs == null)
            {
                return NotFound();
            }

            var actionLog = await _context.ActionLogs
                .FirstOrDefaultAsync(m => m.ActionLogID == id);
            if (actionLog == null)
            {
                return NotFound();
            }

            return View(actionLog);
        }

        // POST: ActionLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ActionLogs == null)
            {
                return Problem("Entity set 'WarehouseContext.ActionLogs'  is null.");
            }
            var actionLog = await _context.ActionLogs.FindAsync(id);
            if (actionLog != null)
            {
                _context.ActionLogs.Remove(actionLog);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActionLogExists(int id)
        {
            return _context.ActionLogs.Any(e => e.ActionLogID == id);
        }
    }
}
