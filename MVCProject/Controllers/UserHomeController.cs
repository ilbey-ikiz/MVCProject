using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class UserHomeController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
