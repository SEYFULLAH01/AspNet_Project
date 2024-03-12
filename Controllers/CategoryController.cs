using Microsoft.AspNetCore.Mvc;

namespace AspNet_Project.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
