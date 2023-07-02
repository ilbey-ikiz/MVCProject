using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
