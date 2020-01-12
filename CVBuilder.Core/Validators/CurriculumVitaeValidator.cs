using CVBuilder.Core.Models;
using FluentValidation;
using System;

namespace CVBuilder.Core.Validators
{
    /// <summary>
    /// CurriculumVitae Validator implemented with Fluent validation
    /// This is a example of how we can do, the example is not complete.
    /// </summary>
    public class CurriculumVitaeValidator : AbstractValidator<CurriculumVitae>
    {
        public CurriculumVitaeValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Please specify a First name");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Please specify a Last name");
            RuleFor(x => x.PhoneNumber).NotEqual("").When(x => x.Address == null);
            RuleFor(x => x.EmailAddress).Length(5, 250);
            RuleFor(x => x.Birthday).Must(BeAValidBirthday).WithMessage("You need to have at least 18 years.");
            // TODO: Add and fix the validations, this is only an example build for the interview.
        }

        private bool BeAValidBirthday(DateTime date)
        {
            return date.AddYears(18) <= DateTime.Now;
        }
    }
}
