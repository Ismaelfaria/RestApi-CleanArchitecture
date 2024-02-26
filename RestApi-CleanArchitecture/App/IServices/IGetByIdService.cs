using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.IServices
{
    public interface IGetByIdService
    {
        User FindById(Guid id);
    }
}
