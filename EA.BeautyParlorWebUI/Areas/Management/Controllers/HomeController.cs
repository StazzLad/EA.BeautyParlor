using Microsoft.AspNetCore.Mvc;

namespace EA.BeautyParlorWebUI.Areas.Management.Controllers
{
    [Area("Management")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
