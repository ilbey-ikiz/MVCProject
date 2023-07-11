using Microsoft.AspNetCore.Mvc;
using MVCProject.Repository.Abstract;

namespace MVCProject.Controllers
{
    public class ManagementController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public ManagementController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
           return View();
        }
        public IActionResult List()
        {
            int data = Convert.ToInt32(HttpContext.Session.GetString("Id"));
            int companyID = employeeRepository.GetById(data).CompanyId;
            var adminList = employeeRepository.GetEmployeesByCompanyIdAdmins(companyID);
            var employeeList = employeeRepository.GetEmployeesByCompanyIdEmployees(companyID);
            var companyEmployeesList = (adminList, employeeList);
            return PartialView("_ListPartial",companyEmployeesList);
        }

        public IActionResult CreateEmployee()
        {
            return PartialView("_CreateEmployeePartial");
        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
