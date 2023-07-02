using MVCProject.Entities.Concrete;

namespace MVCProject.Models
{
    public class EmployeeCompanyVM
    {
        public EmployeeCompanyVM()
        {
            Company = new();
            Employee = new();
        }
        public Company Company { get; set; }
        public Employee Employee { get; set; }
    }
}
