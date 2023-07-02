using DAL;
using MVCProject.Entities.Concrete;
using MVCProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository.Concrete
{
    public class CompanyRepository:GenericRepository<Company> , ICompanyRepository
    {
        private readonly StorageManagementContext dbContext;
        public CompanyRepository(StorageManagementContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

    }
}
