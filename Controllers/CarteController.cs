using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using model1.ContextModels;
using model1.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace model1.Controllers
{
    public class CarteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Comanda/Create
        public async Task<IActionResult> Create()
        {
            ViewData["AutorId"] = new SelectList(await _context.Autor.ToListAsync(), "Id", "Nume");
            return View();
        }

        //POST: Comanda/Create
        [HttpPost]
        public async Task<IActionResult> Create(Carte carte)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carte);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home"); ;
            }

            ViewData["AutorId"] = new SelectList(await _context.Autor.ToListAsync(), "Id", "Nume", carte.AutorId);
            return View(carte);

        }

        // GET: Comanda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var carte = await _context.Carte.FindAsync(id);
            if (carte == null) return NotFound();

            ViewBag.AutorId = new SelectList(_context.Autor, "Id", "Nume", carte.AutorId);
            return View(carte);
        }

        // POST: Comanda/Edit/5
        [HttpPost]

        public async Task<IActionResult> Edit(int id, Carte carte)
        {
            if (id != carte.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carte);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Carte.Any(e => e.Id == carte.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction("Index", "Home");
            }

            ViewBag.AutorId = new SelectList(_context.Autor, "Id", "Nume", carte.AutorId);
            return View(carte);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var carte = await _context.Carte
                .Include(c => c.Autor)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (carte == null)
                return NotFound();

            return View(carte);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carte = await _context.Carte.FindAsync(id);
            if (carte != null)
            {
                _context.Carte.Remove(carte);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Index()
        {
            var carte = await _context.Carte
                .Include(c => c.Autor)
                .ToListAsync();

            return View(carte);
        }
    }
}
