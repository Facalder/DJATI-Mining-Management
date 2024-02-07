using System.ComponentModel.DataAnnotations;

namespace DJATI_EAM.Shared.Model
{
    public class SimplePerson
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly? BirthDate { get; set; }
    }
}