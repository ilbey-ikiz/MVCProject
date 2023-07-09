using BLL.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCProject.Entities.Concrete;
using MVCProject.Models;
using MVCProject.Repository.Abstract;
using MVCProject.Repository.Concrete;

namespace MVCProject.Controllers
{
    public class StoragesController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IColumnRepository columnRepository;
        private readonly IStorageRepository storageRepository;
        Employee employee;
        string id ="1";

        int id1 = 1;

        public StoragesController(IEmployeeRepository employeeRepository, IColumnRepository columnRepository,IStorageRepository storageRepository)
        {
            this.employeeRepository = employeeRepository;
            this.columnRepository = columnRepository;
            this.storageRepository = storageRepository;
            employee = employeeRepository.GetEmployeeIncludeStorage(id1);
        }
        public IActionResult Index()
        {

            //string id = HttpContext.Session.GetString("Id");

            if (id != null)
            {
                //int userId = Convert.ToInt32(id);
                //Employee employee = employeeRepository.GetEmployeeIncludeStorage(userId);
                StorageVM storageVM = new StorageVM()
                {
                    EmployeeType = employee.EmployeeType,
                    Storages = employee.Storages.ToList()
                };
                return View(storageVM);               
            }
            return View();
        }

        public IActionResult List()
        {
            //int userId = Convert.ToInt32(id);
            //Employee employee = employeeRepository.GetEmployeeIncludeStorage(userId);
            StorageVM storageVM = new StorageVM()
            {
                EmployeeType = employee.EmployeeType,
                Storages = employee.Storages.ToList()
            };
            return PartialView("_GetListPartial", storageVM);
        }
        public IActionResult CreateStorage()
        {
            return PartialView("_CreateStoragePartial");
        }
        [HttpPost]
        public IActionResult CreateStorage(CreateStorageVM cVM)
        {
            Storage storage = new Storage();
            storage.StorageName = cVM.StorageName;
            storageRepository.Add(storage);
            storage = storageRepository.GetById(storage.Id);
            int userId = Convert.ToInt32(id);
            foreach (var columnName in cVM.columnNameList)
            {
                if (columnName == null)
                    continue;
                Column column = columnRepository.GetFirstOrDefault(c => c.ColumnName == columnName);
                if (column == null)
                {
                    Column newCloumn = new Column() { ColumnName = columnName };
                    columnRepository.Add(newCloumn);
                    storage.Columns.Add(newCloumn);
                }
                else
                {
                    storage.Columns.Add(column);
                }
            }                        
            storageRepository.Update(storage);
            Employee employee = employeeRepository.GetEmployeeIncludeStorage(userId);
            employee.Storages.Add(storage);
            employeeRepository.Update(employee);
            return Json("ok");
        }
    }
}
