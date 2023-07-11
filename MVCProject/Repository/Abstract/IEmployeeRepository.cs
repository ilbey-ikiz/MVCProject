using BLL.Repository;
using MVCProject.Entities.Concrete;

namespace MVCProject.Repository.Abstract
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        public Employee GetEmployeeByMailAndPassword(string email , string password);

        public IEnumerable<Employee> GetEmployeesByCompanyIdAdmins(int comId);
        public IEnumerable<Employee> GetEmployeesByCompanyIdEmployees(int comId);
    }
}
