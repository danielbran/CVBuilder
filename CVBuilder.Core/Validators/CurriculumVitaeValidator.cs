using CVBuilder.Core.Models;
using FluentValidation;
using System;

namespace CVBuilder.Core.Validators
{
    public class CurriculumVitaeValidator : AbstractValidator<CurriculumVitae>
    {
        public CurriculumVitaeValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Please specify a First name");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Please specify a Last name");
            RuleFor(x => x.PhoneNumber).NotEqual("").When(x => x.Address == null);
            RuleFor(x => x.EmailAddress).Length(5, 250);
            RuleFor(x => x.Birthday).Must(BeAValidBirthday).WithMessage("You need to have at least 18 years.");
        }

        private bool BeAValidBirthday(DateTime date)
        {
            return date.AddYears(18) <= DateTime.Now;
        }
    }
}
