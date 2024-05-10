using Microsoft.AspNetCore.Mvc;

namespace Pronia.Controllers
{
    public class ShopController : Controller
    {
        public async Task <IActionResult> Shop()
        {
            return View();
        }

    }
}
