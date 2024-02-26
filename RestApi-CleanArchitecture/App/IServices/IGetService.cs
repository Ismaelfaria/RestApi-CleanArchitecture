using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.IServices
{
    public interface IGetService
    {
        IEnumerable<User> FindAll();
    }
}
