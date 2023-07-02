using FluentValidation;
using MVCProject.Entities.Concrete;

namespace MVCProject.Validations
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(20)
                .MinimumLength(2)
                .Must(name => !ContainsNumber(name));


            RuleFor(x => x.Mail)
                    .NotEmpty()
                    .NotNull()
                    .EmailAddress();

        }
        private bool ContainsNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;
            return value.Any(char.IsDigit);
        }
    }
}
