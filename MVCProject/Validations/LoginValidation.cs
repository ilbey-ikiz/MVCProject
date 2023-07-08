using FluentValidation;
using MVCProject.Models;

namespace MVCProject.Validations
{
    public class LoginValidation : AbstractValidator<EmployeeLoginVM>
    {
        public LoginValidation()
        {
            RuleFor(s => s.Mail).NotEmpty();
            
        }
    }
}
