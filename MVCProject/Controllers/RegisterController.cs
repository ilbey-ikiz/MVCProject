using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using MVCProject.Repository.Abstract;

namespace MVCProject.Controllers
{
    public class RegisterController : Controller
    {
        IEmployeeRepository EmployeeRepository;
        ICompanyRepository CompanyRepository;
        public RegisterController(IEmployeeRepository empRep , ICompanyRepository comRep)
        {
            EmployeeRepository = empRep;
            CompanyRepository = comRep; 
        }
        public IActionResult Index()
        {
            return View(new EmployeeCompanyVM());
        }


    }
}
