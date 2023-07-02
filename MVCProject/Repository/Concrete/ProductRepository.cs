using BLL.Repository;
using DAL;
using MVCProject.Entities.Concrete;
using MVCProject.Repository.Abstract;

namespace MVCProject.Repository.Concrete
{
    public class ProductRepository: GenericRepository<Product> , IProductRepository
    {
        private readonly StorageManagementContext dbContext;
        public ProductRepository(StorageManagementContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
