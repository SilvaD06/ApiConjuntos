using RealStateWebDotNet7Api.Domain.Entity;

namespace RealStateWebDotNet7Api.Domain.Interface
{
    public interface IUsersDomain
    {
        Users Authenticate(string username, string password);
    }
}
