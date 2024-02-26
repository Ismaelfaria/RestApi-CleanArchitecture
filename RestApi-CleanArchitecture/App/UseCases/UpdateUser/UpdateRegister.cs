using RestApi_CleanArchitecture.App.IServices;
using RestApi_CleanArchitecture.App.Repositories;
using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.UseCases.UpdateUser
{
    public class UpdateRegister : IUpdateService
    {
        private readonly IRepositoryUpdateRegister _ResUpdate;
        public UpdateRegister(IRepositoryUpdateRegister ResUpdate)
        {
            _ResUpdate = ResUpdate;
        }
        public User Update(Guid id, User user)
        {
            return _ResUpdate.Update(id, user);
        }
    }
}
