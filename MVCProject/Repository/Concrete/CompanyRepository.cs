using DAL;
using MVCProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository.Concrete
{
    public class CompanyRepository:GenericRepository<Company>
    {
        private readonly StorageManagementContext dbContext;
        public CompanyRepository(StorageManagementContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

    }
}
