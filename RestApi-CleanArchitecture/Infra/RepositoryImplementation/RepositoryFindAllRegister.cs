using RestApi_CleanArchitecture.App.Repositories;
using RestApi_CleanArchitecture.Domain;
using RestApi_CleanArchitecture.Infra.ContextoBd;

namespace RestApi_CleanArchitecture.Infra.RepositoryImplementation
{
    public class RepositoryFindAllRegister : IRepositoryFindAllRegister
    {
        private readonly BdContext _context;
        public RepositoryFindAllRegister(BdContext context)
        {
            _context = context;
        }
        public IEnumerable<User> FindAll()
        {
            var registers = _context.User.Where(us => !us.IsDeleted).ToList();

            return registers;
        }
    }
}
