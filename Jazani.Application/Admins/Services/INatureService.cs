

using Jazani.Application.Admins.Dtos.Periocities;

namespace Jazani.Application.Admins.Services
{
    public interface INatureService
    {
        Task<IReadOnlyList<NatureDto>> FindAllAsync();
        Task<NatureDto?> FindByIdAsync(int id);
        Task<NatureDto> CreateAsync(NatureSaveDto natureSaveDto);
        Task<NatureDto> EditAsync(int id, NatureSaveDto natureSaveDto);
        Task<NatureDto> DisabledAsync(int id);
    }
}
