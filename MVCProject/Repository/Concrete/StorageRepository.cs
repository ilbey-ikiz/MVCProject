using BLL.Repository;
using DAL;
using MVCProject.Entities.Concrete;
using MVCProject.Repository.Abstract;

namespace MVCProject.Repository.Concrete
{
    public class StorageRepository : GenericRepository<Storage> , IStorageRepository
    {
        private readonly StorageManagementContext dbContext;
        public StorageRepository(StorageManagementContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
