

namespace Jazani.Domain.Admins.Models
{
    public class Alertt
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTimeOffset StartDate { get; set; } 
        public DateTimeOffset EndDate { get; set; } 
        public int? RuletypeId { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        public bool State { get; set; }
        
    }
}
