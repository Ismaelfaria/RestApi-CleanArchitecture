using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.IServices
{
    public interface ICreateService
    {
        User Save(User user);
    }
}
