using DAL;
using Microsoft.EntityFrameworkCore;
using MVCProject.Entities.Concrete;
using MVCProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly StorageManagementContext dbContext;
        public EmployeeRepository(StorageManagementContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public Employee? GetEmployeeByMailAndPassword(string email, string password)
        {
            return dbContext.Employees.FirstOrDefault(s => s.Mail == email && s.Password == password);
        }

        public Employee GetEmployeeIncludeStorage(int id)
        {
            return dbContext.Employees.Include(e => e.Storages).FirstOrDefault(e => e.Id == id);
        }
    }
}
