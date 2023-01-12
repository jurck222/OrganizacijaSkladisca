using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web.Data;
using web.Models;
using Microsoft.AspNetCore.Authorization;
using System.Web.Mvc;

namespace web.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class ArticleController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly WarehouseContext _context;

        public ArticleController(WarehouseContext context)
        {
            _context = context;
        }

        // GET: Article
        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.Articles == null)
            {
                return Problem("Entity set 'WarehouseContext.Article'  is null.");

            }

            var articles = from a in _context.Articles
                        select a;

            if (!String.IsNullOrEmpty(searchString))
            {
                articles = articles.Where(s => s.Description!.Contains(searchString));
            }

            return View(await articles.ToListAsync());
        }


        // GET: Article/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Articles == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .FirstOrDefaultAsync(m => m.ArticleID == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // GET: Article/Create
        [Microsoft.AspNetCore.Authorization.Authorize(Roles ="Admin,WarehouseLeader,Worker")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        [Microsoft.AspNetCore.Authorization.Authorize(Roles ="Admin,WarehouseLeader,Worker")]
        public async Task<IActionResult> Create([Microsoft.AspNetCore.Mvc.Bind("ArticleID,Code,Description,Quantity")] Article article)
        {
            if (ModelState.IsValid)
            {
                _context.Add(article);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(article);
        }

        // GET: Article/Edit/5
        [Microsoft.AspNetCore.Authorization.Authorize(Roles ="Admin,WarehouseLeader")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Articles == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }

        // POST: Article/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        [Microsoft.AspNetCore.Authorization.Authorize(Roles ="Admin,WarehouseLeader")]
        public async Task<IActionResult> Edit(int id, [Microsoft.AspNetCore.Mvc.Bind("ArticleID,Code,Description,Quantity")] Article article)
        {
            if (id != article.ArticleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.ArticleID))
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
            return View(article);
        }

        // GET: Article/Delete/5
        [Microsoft.AspNetCore.Authorization.Authorize(Roles ="Admin,WarehouseLeader")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Articles == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .FirstOrDefaultAsync(m => m.ArticleID == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }
        [Microsoft.AspNetCore.Authorization.Authorize(Roles ="Admin,WarehouseLeader")]
        // POST: Article/Delete/5
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.ActionName("Delete")]
        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Articles == null)
            {
                return Problem("Entity set 'WarehouseContext.Articles'  is null.");
            }
            var article = await _context.Articles.FindAsync(id);
            if (article != null)
            {
                _context.Articles.Remove(article);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.ArticleID == id);
        }
    }
}
