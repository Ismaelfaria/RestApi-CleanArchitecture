using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.IServices
{
    public interface IUpdateService
    {
        User Update(Guid id, User user);
    }
}
