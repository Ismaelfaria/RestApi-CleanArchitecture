using RestApi_CleanArchitecture.App.IServices;
using RestApi_CleanArchitecture.App.Repositories;

namespace RestApi_CleanArchitecture.App.UseCases.DeleteUser
{
    public class DeleteRegister : IDeleteService
    {
        private readonly IRepositoryDeletedRegister _RepDelete;
        public DeleteRegister(IRepositoryDeletedRegister RepDelete)
        {
            _RepDelete = RepDelete;
        }
        public bool Delete(Guid id)
        {
            return _RepDelete.Delete(id);
        }
    }
}
