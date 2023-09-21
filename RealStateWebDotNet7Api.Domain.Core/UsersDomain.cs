using RealStateWebDotNet7Api.Domain.Entity;
using RealStateWebDotNet7Api.Domain.Interface;
using RealStateWebDotNet7Api.Infra.Interface;

namespace RealStateWebDotNet7Api.Domain.Core
{
    public class UsersDomain : IUsersDomain
    {
        private readonly IUserRepository _usersRepository;

        public UsersDomain(IUserRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public Users Authenticate(string username, string password)
        {
           return _usersRepository.Authenticate(username, password);
        }
    }
}
