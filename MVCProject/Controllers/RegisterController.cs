using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Entities.Concrete;
using MVCProject.Extensions;
using MVCProject.Models;
using MVCProject.Repository.Abstract;

namespace MVCProject.Controllers
{
    public class RegisterController : Controller
    {
        IEmployeeRepository EmployeeRepository;
        ICompanyRepository CompanyRepository;
        IValidator<EmployeeCompanyVM> validator;
        IMapper mapper;
        public RegisterController(IEmployeeRepository empRep , ICompanyRepository comRep , IMapper mapper , IValidator<EmployeeCompanyVM> validator)
        {
            EmployeeRepository = empRep;
            CompanyRepository = comRep; 
            this.validator = validator;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(EmployeeCompanyVM ecVM)
        {
            var result = validator.Validate(ecVM);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return View("Index", ecVM);
            }
           //return RedirectToAction("Index" , "Login");
           return View();
        }


    }
}
