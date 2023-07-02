using BLL.Repository;
using DAL;
using MVCProject.Entities.Concrete;

namespace MVCProject.Repository.Concrete
{
    public class ProductRepository: GenericRepository<Product>
    {
        private readonly StorageManagementContext dbContext;
        public ProductRepository(StorageManagementContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
