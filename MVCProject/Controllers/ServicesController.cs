using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
