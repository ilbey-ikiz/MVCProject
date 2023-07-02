using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
