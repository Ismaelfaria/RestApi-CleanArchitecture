using RestApi_CleanArchitecture.App.IServices;
using RestApi_CleanArchitecture.App.Repositories;
using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.UseCases.GetById
{
    public class GetByIdRegister : IGetByIdService
    {
        private readonly IRepositoryFindByIdRegister _RepFindById;
        public GetByIdRegister(IRepositoryFindByIdRegister RepFindById)
        {
            _RepFindById = RepFindById;
        }
        public User FindById(Guid id)
        {
            return _RepFindById.FindById(id);
        }
    }
}
