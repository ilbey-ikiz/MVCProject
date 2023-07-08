using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class SampleStoragesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
