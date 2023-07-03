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
        IValidator<Employee> validator;
        IEmployeeRepository employeeRepository;
        IMapper mapper;
        public LoginController(IValidator<Employee> validator, IEmployeeRepository employeeRepository, IMapper map)
        {
            this.validator = validator;
            this.employeeRepository = employeeRepository;
            this.mapper = map;
        }
        public IActionResult Index()
        {
            return View(new EmployeeLoginVM());
        }

        [HttpPost]
        public async Task<IActionResult> Index(EmployeeLoginVM userVm)
        {
            Employee employee = mapper.Map<Employee>(userVm);   
            var result = await validator.ValidateAsync(employee);
            Employee employeeLogin = employeeRepository.GetEmployeeByMailAndPassword(userVm.Mail, userVm.Password);

            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return View("Index", userVm);
            }
            if(employeeLogin is null)
            {
                ViewBag.Info = "Hatali";
                return View("Index", userVm);
            }
            return RedirectToAction("Index" , "StorageController");
        }

        public IActionResult IsPeronExistControl(EmployeeLoginVM loginVM)
        {
            Employee employee =employeeRepository.GetEmployeeByMailAndPassword(loginVM.Mail, loginVM.Password);
            if (employee is null)
            {
                return Json("ok");
            }
            return Json("fail");
        }

    }
}
