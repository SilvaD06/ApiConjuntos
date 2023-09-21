namespace RealStateWebDotNet7Api.Services.WebApi.Helpers
{
    public interface IAppSettings
    {
        string Secret { get; set; }
        string Audience { get; set; }
        string Issuer { get; set; }
    }
}
