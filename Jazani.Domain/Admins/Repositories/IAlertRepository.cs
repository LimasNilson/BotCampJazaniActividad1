using Jazani.Domain.Admins.Models;

namespace Jazani.Domain.Admins.Repositories
{
    public interface IAlertRepository
    {
        Task<IReadOnlyList<Alertt>> FindAllAsync();
        Task<Alertt?> FindByIdAsync(int id);
        Task<Alertt> SaveAsync(Alertt alert);
    }
}
