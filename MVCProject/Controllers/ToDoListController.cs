using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class ToDoListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
