using FluentValidation;
using Recipe05.Models;

namespace Recipe05.Validation
{
    public class GuitarValidator : AbstractValidator<Guitar>
    {
        public GuitarValidator()
        {
            // guitar name can not be null, empty, or whitespace and must be at least 3 but no more then 40 characters long
            RuleFor(guitar => guitar.Name).NotEmpty().Length(3, 40);

            // guitar must have a body
            RuleFor(guitar => guitar.Body).NotEmpty();
            // guitar must have a pickup install in each slot available in the selected body
            RuleFor(guitar => guitar.NeckPickup).NotEmpty().When(guitar => (guitar.Body != null) && guitar.Body.AllowNeckPickup);
            RuleFor(guitar => guitar.BridgePickup).NotEmpty().When(guitar => (guitar.Body != null) && guitar.Body.AllowBridgePickup);
            RuleFor(guitar => guitar.MiddlePickup).NotEmpty().When(guitar => (guitar.Body != null) && guitar.Body.AllowMiddlePickup);
            // can't select more strings then guitar body supports
            RuleFor(guitar => guitar.Strings)
                .NotNull()
                .Must((guitar, strings) => strings?.Count == guitar?.Body?.NumberOfStringsSupported)
                .WithMessage(@"The number of strings selected {0} 
                              does not match the number supported by the guitar body {1}",
                guitar => guitar?.Strings?.Count,
                guitar => guitar?.Body?.NumberOfStringsSupported);

            // can't add a middle pickup if the guitar body does not support it
            RuleFor(guitar => guitar.MiddlePickup)
                .Null()
                .When(guitar => ((guitar.Body != null) && (guitar.Body?.AllowMiddlePickup == false)));


        }
    }
}
