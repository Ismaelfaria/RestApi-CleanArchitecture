using RestApi_CleanArchitecture.App.Repositories;
using RestApi_CleanArchitecture.Infra.ContextoBd;

namespace RestApi_CleanArchitecture.Infra.RepositoryImplementation
{
    public class RepositoryDeletedRegister : IRepositoryDeletedRegister
    {
        private readonly BdContext _context;
        public RepositoryDeletedRegister(BdContext context)
        {
            _context = context;
        }
        public bool Delete(Guid id)
        {
            var register = _context.User.SingleOrDefault(de => de.Id == id);

            if(register == null)
            {
                return false;
            }

            register.Deleted();
            _context.SaveChanges();

            return true;
        }
    }
}
