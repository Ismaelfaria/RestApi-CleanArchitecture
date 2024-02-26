using RestApi_CleanArchitecture.App.IServices;
using RestApi_CleanArchitecture.App.Repositories;
using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.UseCases.CreateUser
{
    public class CreateRegister : ICreateService
    {
        private readonly IRepositorySaveRegister _RepSave;
        public CreateRegister(IRepositorySaveRegister RepSave)
        {
            _RepSave = RepSave;
        }
        public User Save(User user)
        {
            return _RepSave.Save(user);
        }
    }
}
