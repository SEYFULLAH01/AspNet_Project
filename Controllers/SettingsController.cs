using Microsoft.AspNetCore.Mvc;

namespace AspNet_Project.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
