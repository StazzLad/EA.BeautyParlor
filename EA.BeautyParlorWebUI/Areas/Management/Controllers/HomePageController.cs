using EA.BLL.Abstract;
using EA.BLL.Concrete;
using EA.Entity.Entities;
using KB.MindShift.WebUI.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;



namespace EA.BeautyParlorWebUI.Areas.Management.Controllers
{
    [Area("Management")]
    public class HomePageController : Controller
    {
        private readonly IIndexComponentBLL _context;
        private readonly IWebHostEnvironment _env;
        public HomePageController( IWebHostEnvironment env)
        {
            _context = new IndexComponentBLL();
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.GetActiveComponents();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IndexComponent model, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                    model.ImageUrl = await FileUploader.UploadAsync(_env, image);

                bool result = _context.Add(model);

                if (result)
                    return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SetActiveImage (Guid Id)
        {
            _context.SetActiveImage(Id);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<JsonResult> Delete(Guid id)
        {
            IndexComponent? model = await _context
                .IndexComponents
                .FirstOrDefaultAsync(x => x.Id == id && x.Status != 2);

            if (model == null)
                return Json(new { success = false, message = "Ürün Resmi Bulunamadı" });

            await FileUploader.DeleteAsync(_env, model.ImageUrl);
            _context.IndexComponents.Remove(model);
            _context.Entry(model).State = EntityState.Deleted;

            int response = await _context.SaveChangesAsync();
            if (response >= 1)
            {
                return Json(new { success = true, message = "Ürün Resmi Silindi!" });
            }
            return Json(new { success = false, message = "Ürün Resmi Silinemedi!" });

        }

    }
}
