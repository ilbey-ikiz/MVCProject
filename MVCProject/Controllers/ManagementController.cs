using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class ManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
