using FluentValidation;
using MVCProject.Models;

namespace MVCProject.Validations
{
    public class EmployeeRegisterValidator : AbstractValidator<EmployeeRegisterVM>
    {
        public EmployeeRegisterValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().NotNull().Must(ContainsNumber).WithMessage("hata");
            RuleFor(s => s.LastName).NotEmpty().NotNull().MaximumLength(5);
            RuleFor(x => x.BirthDate)
            .LessThan(DateTime.Today).WithMessage("hata");
            RuleFor(s => s.Mail).NotEmpty().NotNull();
            RuleFor(s => s.Phone).NotEmpty().NotNull();
            RuleFor(s => s.Password).NotEmpty().NotNull();
            RuleFor(s => s.PasswordConfirm).Equal(s => s.Password).WithMessage("Eslesmiyor.");
            

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

