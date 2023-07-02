using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class StoragesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
