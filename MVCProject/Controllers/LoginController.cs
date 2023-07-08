using AutoMapper;
using BLL.Repository;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Entities.Concrete;
using MVCProject.Models;
using MVCProject.Repository.Abstract;
using MVCProject.Validations;
using System;

namespace MVCProject.Controllers
{
    public class LoginController : Controller
    {
        IValidator<EmployeeLoginVM> validator;
        IEmployeeRepository employeeRepository;
        IMapper mapper;
        public LoginController(IValidator<EmployeeLoginVM> validator, IEmployeeRepository employeeRepository, IMapper map)
        {
            this.validator = validator;
            this.employeeRepository = employeeRepository;
            this.mapper = map;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(EmployeeLoginVM userVm)
        {
            Employee employee = mapper.Map<Employee>(userVm);
            Employee employeeLogin = employeeRepository.GetEmployeeByMailAndPassword(userVm.Mail, userVm.Password);

            if (!ModelState.IsValid)
            {
                return View("Index", userVm);
            }
            if (employeeLogin is null)
            {
                ViewBag.Info = "Hatali";
                return View("Index", userVm);
            }
            return RedirectToAction("Index", "UserHome");
        }

        public IActionResult IsPeronExistControl(EmployeeLoginVM loginVM)
        {
            Employee employee = employeeRepository.GetEmployeeByMailAndPassword(loginVM.Mail, loginVM.Password);
            if (employee is not null)
            {
                HttpContext.Session.SetString("Id", $"{employee.Id}");
                return Json(employee.Id);
            }
            return Json("fail");
        }

    }
}
