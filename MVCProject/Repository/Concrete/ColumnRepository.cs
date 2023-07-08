using BLL.Repository;
using DAL;
using MVCProject.Entities.Concrete;
using MVCProject.Repository.Abstract;

namespace MVCProject.Repository.Concrete
{
    public class ColumnRepository : GenericRepository<Column> , IColumnRepository
    {
        private readonly StorageManagementContext dbContext;
        public ColumnRepository(StorageManagementContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
