using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class UserHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
