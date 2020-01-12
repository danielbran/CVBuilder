using CVBuilder.Core.Models;
using FluentValidation;

namespace CVBuilder.Core.Validators
{
    /// <summary>
    /// Address Validator implemented with Fluent validation
    /// This is a example of how we can do, the example is not complete.
    /// </summary>
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Country).Must(BeAValidPostcode).WithMessage("Please specify a Country");
            RuleFor(x => x.County).NotEmpty().WithMessage("Please specify a County");
            RuleFor(x => x.City).NotEqual(string.Empty).When(x => x.Street == null);
            RuleFor(x => x.Street).Length(20, 250);
            RuleFor(x => x.StreetNumber).Length(20, 250).WithMessage("Please specify a valid streetNumber");
            RuleFor(x => x.PostalCode).Must(BeAValidPostcode).WithMessage("Please specify a valid postcode");
        }
        private bool BeAValidPostcode(string postcode)
        {
            // custom postcode validating logic goes here
            return !string.IsNullOrEmpty(postcode);
        }

        private bool BeAValidCountry(string country)
        {
            // custom country validating logic goes here
            // all countries are available throw an api, we can check if the name is into the list.
            return !string.IsNullOrEmpty(country);
        }
    }
}
