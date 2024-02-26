using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.Repositories
{
    public interface IRepositoryFindAllRegister
    {
        IEnumerable<User> FindAll();
    }
}
