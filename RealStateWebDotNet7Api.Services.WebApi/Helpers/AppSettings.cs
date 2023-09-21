namespace RealStateWebDotNet7Api.Services.WebApi.Helpers
{
    public class AppSettings : IAppSettings
    {
        public string Secret { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
    
    }
}
