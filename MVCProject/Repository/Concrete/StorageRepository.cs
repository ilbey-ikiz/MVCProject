using BLL.Repository;
using DAL;
using MVCProject.Entities.Concrete;

namespace MVCProject.Repository.Concrete
{
    public class StorageRepository : GenericRepository<Storage>
    {
        private readonly StorageManagementContext dbContext;
        public StorageRepository(StorageManagementContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
