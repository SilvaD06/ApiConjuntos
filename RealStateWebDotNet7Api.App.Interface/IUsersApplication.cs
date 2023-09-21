using RealStateWebDotNet7Api.App.DTO;
using RealStateWebDotNet7Api.CrossApp.Common;


namespace RealStateWebDotNet7Api.App.Interface
{
    public interface IUsersApplication
    {
        Response<UsersDto> Authenticate(string username, string password);
    }
}
