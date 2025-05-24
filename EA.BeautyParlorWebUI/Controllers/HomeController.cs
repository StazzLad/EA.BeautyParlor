using EA.BLL.Abstract;
using EA.BLL.Concrete;
using EA.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EA.BeautyParlorWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IIndexComponentBLL _context;
        public HomeController(IIndexComponentBLL context)
        {
            _context = context;
        }
        public  async Task<IActionResult> Index()
        {
            var components = await _context.GetActiveComponents();
            var activeImage = components.FirstOrDefault(img => img.IsActive); 

            
            return View(activeImage);
            
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Reservation() 
        { return View(); }


        public IActionResult Portfolio()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
