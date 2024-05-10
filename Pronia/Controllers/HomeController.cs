using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.DataAccessLayer;
using Pronia.ViewModels.Categories;

namespace Pronia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProniaContext _context;

        public HomeController(ProniaContext context)
        {
            _context = context;
        }
        public async Task< IActionResult> Index ()
        {
         
            return View(await _context.Categories.Where(x=> !x.IsDeleted).Select(x=> new GetCategoryVM
            {
                Id=x.Id,
                Name=x.Name
            }).ToListAsync());
        }
        public async Task<IActionResult> Test(int? id)
        {
            if (id == null|| id<1)
            {
                return BadRequest();
            }
            var cat = await _context.Categories.FindAsync(id);
            if(cat==null) return NotFound();
            _context.Remove(cat);
            await _context.SaveChangesAsync();
            return Content(cat.Name);
        }
        public async Task<IActionResult> Contact()
        {
            return View();
        }
        public async Task<IActionResult> About()
        {
            return View();
        }
    }
}
