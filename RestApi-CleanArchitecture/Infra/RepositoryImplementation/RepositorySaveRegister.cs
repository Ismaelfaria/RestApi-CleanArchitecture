using RestApi_CleanArchitecture.App.Repositories;
using RestApi_CleanArchitecture.Domain;
using RestApi_CleanArchitecture.Infra.ContextoBd;

namespace RestApi_CleanArchitecture.Infra.RepositoryImplementation
{
    public class RepositorySaveRegister : IRepositorySaveRegister
    {
        private readonly BdContext _context;
        public RepositorySaveRegister(BdContext context)
        {
            _context = context;
        }
        public User Save(User user)
        {
            _context.Add(user);
            _context.SaveChanges();

            return user;
        }
    }
}
