using FluentValidation;
using RestApi_CleanArchitecture.App.IServices;
using RestApi_CleanArchitecture.App.Repositories;
using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.UseCases.CreateUser
{
    public class CreateRegister : ICreateService
    {
        private readonly IRepositorySaveRegister _RepSave;
        private readonly IValidator<User> _validator;
        public CreateRegister(IRepositorySaveRegister RepSave, IValidator<User> validator)
        {
            _RepSave = RepSave;
            _validator = validator;
    }
        public User Save(User user)
        {
            var validator = _validator.Validate(user);

            if (!validator.IsValid)
            {
                throw new ValidationException("Erro de validação ao criar o paciente", validator.Errors);
            }

            user.Id = Guid.NewGuid();

            return _RepSave.Save(user);
        }
    }
}
