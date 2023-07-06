using FluentValidation;
using MVCProject.Models;

namespace MVCProject.Validations
{
    public class EmployeeRegisterValidator : AbstractValidator<EmployeeRegisterVM>
    {
        public EmployeeRegisterValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().NotNull().Must(ContainsNumber);
            RuleFor(s => s.LastName).NotEmpty().NotNull().MaximumLength(5);
            RuleFor(x => x.BirthDate)
            .NotEmpty()
            .Must(BeAValidDate).WithMessage("Geçerli bir tarih girin.");
            RuleFor(s => s.Mail).NotEmpty().NotNull();
            RuleFor(s => s.Phone).NotEmpty().NotNull();
            RuleFor(s => s.Password).NotEmpty().NotNull().NotEqual(s=> s.PasswordConfirm);
            RuleFor(s => s.PasswordConfirm).NotEqual(s => s.Password);

        }

        private bool BeAValidDate(DateTime birthDate)
        {
            return birthDate <= DateTime.Now;
        }

        private bool ContainsNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return true;
            return !value.Any(char.IsDigit);
        }
    }
}

