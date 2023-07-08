using FluentValidation;
using MVCProject.Models;

namespace MVCProject.Validations
{
    public class EmployeeLoginValidator : AbstractValidator<EmployeeLoginVM>
    {
        public EmployeeLoginValidator()
        {
            RuleFor(x => x.Mail)
                    .EmailAddress();

        }


    }
}

