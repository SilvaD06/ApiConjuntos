namespace RealStateWebDotNet7Api.Domain.Entity
{
    public class Residents
    {
        //Avoid warning from nullable objects by setting default value. 
        //Also can define as nullable properties - type?
        //Inactive warnings from configs default- enable
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