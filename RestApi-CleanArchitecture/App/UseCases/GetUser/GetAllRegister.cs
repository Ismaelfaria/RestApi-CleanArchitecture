using RestApi_CleanArchitecture.App.IServices;
using RestApi_CleanArchitecture.App.Repositories;
using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.UseCases.GetUser
{
    public class GetAllRegister : IGetService
    {
        private readonly IRepositoryFindAllRegister _RepFindAll;
        public GetAllRegister(IRepositoryFindAllRegister RepFindAll)
        {
            _RepFindAll = RepFindAll;
        }
        public IEnumerable<User> FindAll()
        {
            return _RepFindAll.FindAll();
        }
    }
}
