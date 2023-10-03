

namespace Jazani.Application.Admins.Dtos.Alert
{
    public class AlertDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTimeOffset? RegistrationDate { get; set; }
        public int? RuletipeId{ get; set; }
        public bool State { get; set; }
    }
}
