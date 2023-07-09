using BLL.Repository;
using MVCProject.Entities.Concrete;

namespace MVCProject.Repository.Abstract
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        public Employee GetEmployeeByMailAndPassword(string email, string password);
        Employee GetEmployeeIncludeStorage(int id);
    }
}
