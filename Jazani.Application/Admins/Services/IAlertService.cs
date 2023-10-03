using Jazani.Application.Admins.Dtos.Alert;

namespace Jazani.Application.Admins.Services
{
    public interface IAlertService
    {
        Task<IReadOnlyList<AlertDto>> FindAllAsync();
        Task<AlertDto?> FindByIdAsync(int id);
        Task<AlertDto> CreateAsync(AlertSaveDto alertSaveDto);
        Task<AlertDto> EditAsync(int id, AlertSaveDto alertSaveDto);
        Task<AlertDto> DisabledAsync(int id);
    }
}
