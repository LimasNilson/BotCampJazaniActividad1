using Jazani.Domain.Admins.Models;
using Jazani.Domain.Admins.Repositories;
using Jazani.Infrastructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Jazani.Infrastructure.Cores.Persistenses
{
    public class NatureRepository : INatureRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public NatureRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IReadOnlyList<Nature>> FindAllAsync()
        {
            return await _dbContext.Natures.ToListAsync();
        }

        public async Task<Nature?> FindByIdAsync(int id)
        {
            return await _dbContext.Natures.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Nature> SaveAsync(Nature nature)
        {
            EntityState state = _dbContext.Entry(nature).State;

            _ = state switch
            {
                EntityState.Detached => _dbContext.Natures.Add(nature),
                EntityState.Modified => _dbContext.Natures.Update(nature),
            };

            await _dbContext.SaveChangesAsync();
            return nature;
        }
    }
}
