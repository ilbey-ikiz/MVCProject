using DAL;
using MVCProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class EmployeeRepository:GenericRepository<Employee>
    {
        private readonly StorageManagementContext dbContext;
        public EmployeeRepository(StorageManagementContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
