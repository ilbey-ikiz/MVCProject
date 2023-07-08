using MVCProject.Entities.Concrete;

namespace MVCProject.Models
{
    public class EmployeeCompanyVM
    {
        //public EmployeeCompanyVM()
        //{
        //    Company = new();
        //    Employee = new();
        //}
        public CompanyRegisterVM Company { get; set; }
        public EmployeeRegisterVM Employee { get; set; }
    }
}
