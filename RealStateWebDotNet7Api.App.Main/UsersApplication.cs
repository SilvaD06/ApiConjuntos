using AutoMapper;
using RealStateWebDotNet7Api.App.DTO;
using RealStateWebDotNet7Api.App.Interface;
using RealStateWebDotNet7Api.CrossApp.Common;
using RealStateWebDotNet7Api.Domain.Interface;


namespace RealStateWebDotNet7Api.App.Main
{
    public class UsersApplication : IUsersApplication
    {
        private readonly IUsersDomain _usersDomain;
        private readonly IMapper _mapper;

        public UsersApplication(IUsersDomain usersDomain, IMapper mapper)
        {
            _usersDomain = usersDomain;
            _mapper = mapper;
        }

        public Response<UsersDto> Authenticate(string username, string password)
        {
          var response = new Response<UsersDto>();
            if(string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password))
            {
                response.Message = "Parameters empty";
                return response;
            }
            try
            {
                var user = _usersDomain.Authenticate(username, password);
                response.Data = _mapper.Map<UsersDto>(user);
                response.IsSuccess = true;
                response.Message = "Auth Succeeded";

            }
           catch (InvalidOperationException e)
            {
                response.Message = e.Message;
                response.IsSuccess = false;
            }
            catch (Exception e)
            {

                response.Message = e.Message;
                response.IsSuccess = false;
            }

            return response;
        }
    }
}
