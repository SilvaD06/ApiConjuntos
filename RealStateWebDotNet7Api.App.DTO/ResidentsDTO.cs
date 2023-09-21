namespace RealStateWebDotNet7Api.App.DTO
{
    public class ResidentsDTO
    {
        public Boolean IsResident { get; set; } = false;
        public int IdResidence { get; set; } = 0;
        public int IdDocumentType { get; set; } = 0;
        public string DocumentNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;

    }
}