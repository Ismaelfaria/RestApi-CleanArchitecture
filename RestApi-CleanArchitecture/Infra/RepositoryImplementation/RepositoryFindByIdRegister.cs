using RestApi_CleanArchitecture.App.Repositories;
using RestApi_CleanArchitecture.Domain;
using RestApi_CleanArchitecture.Infra.ContextoBd;

namespace RestApi_CleanArchitecture.Infra.RepositoryImplementation
{
    public class RepositoryFindByIdRegister : IRepositoryFindByIdRegister
    {
        private readonly BdContext _context;
        public RepositoryFindByIdRegister(BdContext context)
        {
            _context = context;
        }
        public User FindById(Guid id)
        {
            var register = _context.User.SingleOrDefault(de => de.Id == id);

            if(register == null)
            {
                return null;
            }
            return register;
        }
    }
}
