using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class UserHomeController : Controller
    {
        public IActionResult Index()
        {
            string data = HttpContext.Session.GetString("Id");


            return View();
        }
    }
}
