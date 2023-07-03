using FluentValidation;
using MVCProject.Models;

namespace MVCProject.Validations
{
    public class EmployeeCompanyValidator : AbstractValidator<EmployeeCompanyVM>
    {
        public EmployeeCompanyValidator()
        {
            //RuleFor(r => r.Company.CompanyName).NotEmpty()
            //    .NotNull();


            //RuleFor(e => e.Employee.FirstName).NotNull().NotEmpty();
        }

    }
}
