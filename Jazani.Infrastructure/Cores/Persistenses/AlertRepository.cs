using Jazani.Domain.Admins.Models;
using Jazani.Domain.Admins.Repositories;
using Jazani.Infrastructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Jazani.Infrastructure.Cores.Persistenses
{
    public class AlertRepository : IAlertRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public AlertRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IReadOnlyList<Alertt>> FindAllAsync()
        {
            return await _dbContext.Alerts.ToListAsync();
        }

        public async Task<Alertt?> FindByIdAsync(int id)
        {
            return await _dbContext.Alerts.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Alertt> SaveAsync(Alertt alert)
        {
            EntityState state = _dbContext.Entry(alert).State;

            _ = state switch
            {
                EntityState.Detached => _dbContext.Alerts.Add(alert),
                EntityState.Modified => _dbContext.Alerts.Update(alert),
            };

            await _dbContext.SaveChangesAsync();
            return alert;
        }
    }
}
