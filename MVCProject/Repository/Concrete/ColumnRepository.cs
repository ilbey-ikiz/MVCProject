using BLL.Repository;
using DAL;
using MVCProject.Entities.Concrete;

namespace MVCProject.Repository.Concrete
{
    public class ColumnRepository : GenericRepository<Column>
    {
        private readonly StorageManagementContext dbContext;
        public ColumnRepository(StorageManagementContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
