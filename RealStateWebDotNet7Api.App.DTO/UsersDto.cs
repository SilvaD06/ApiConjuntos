

namespace RealStateWebDotNet7Api.App.DTO
{
    public class UsersDto
    {
        public int UserId { get; set; } = 0;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int PersonId { get; set; } = 0;

        public string Token { get; set; } = string.Empty;
    }
}
