using Jazani.Domain.Admins.Models;

namespace Jazani.Domain.Admins.Repositories
{
    public interface INatureRepository
    {
        Task<IReadOnlyList<Nature>> FindAllAsync();
        Task<Nature?> FindByIdAsync(int id);
        Task<Nature> SaveAsync(Nature office);
    }
}
