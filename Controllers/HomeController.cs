using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using model1.ContextModels;
using model1.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace model1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(string? numeAutor)
        {
            var query = _context.Carte.Include(c => c.Autor).AsQueryable();

            if (!string.IsNullOrEmpty(numeAutor))
            {
                query = query.Where(c => c.Autor != null && c.Autor.Nume != null && c.Autor.Nume.Contains(numeAutor));
            }

            var lista = await query.ToListAsync();
            return View(lista);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
