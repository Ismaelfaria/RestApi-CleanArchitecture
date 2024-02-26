using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.Repositories
{
    public interface IRepositorySaveRegister
    {
        User Save(User user);
    }
}
