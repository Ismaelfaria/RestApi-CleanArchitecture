using RestApi_CleanArchitecture.App.Repositories;
using RestApi_CleanArchitecture.Domain;
using RestApi_CleanArchitecture.Infra.ContextoBd;

namespace RestApi_CleanArchitecture.Infra.RepositoryImplementation
{
    public class RepositoryUpdateRegister : IRepositoryUpdateRegister
    {
        private readonly BdContext _context;
        public RepositoryUpdateRegister(BdContext context)
        {
            _context = context;
        }
        public User Update(Guid id, User user)
        {
            var register = _context.User.SingleOrDefault(de => de.Id == id);

            if (register == null)
            {
                return null;
            }

            register.Update(user.Name, user.Age);
            _context.SaveChanges();

            return register;
        }
    }
}
