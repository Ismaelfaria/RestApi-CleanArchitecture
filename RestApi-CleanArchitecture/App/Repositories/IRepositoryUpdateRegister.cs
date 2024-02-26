using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.Repositories
{
    public interface IRepositoryUpdateRegister
    {
        User Update(Guid id, User user);
    }
}
