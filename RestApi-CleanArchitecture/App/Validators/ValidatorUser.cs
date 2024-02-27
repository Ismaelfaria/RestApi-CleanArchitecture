using FluentValidation;
using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.Validators
{
    public class ValidatorUser : AbstractValidator<User>
    {
        public ValidatorUser()
        {
            RuleFor(de => de.Name)
                .NotEmpty()
                .WithMessage("O nome não pode ser nulo");
            
            RuleFor(de => de.Age)
                .NotEmpty()
                .InclusiveBetween(18, 99)
                .WithMessage("A idade deve esta entre 18 e 99 anos");
        }
    }
}
