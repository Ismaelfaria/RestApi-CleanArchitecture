using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.Repositories
{
    public interface IRepositoryFindByIdRegister
    {
        User FindById(Guid id);
    }
}
