using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProtectedAreas.Data.Repositories.Interfaces;
using ProtectedAreas.Models;

namespace ProtectedAreas.Data.Repositories
{
    public class ProtectedAreaRepository : IProtectedAreaRepository
    {
        private readonly AppDbContext _db;

        public ProtectedAreaRepository(AppDbContext db) => _db = db;

        public async Task<ProtectedArea> GetAsync(int id)
        {
            var protectedArea = await _db.ProtectedAreas
                .Include(p => p.ObsoleteNames)
                .Include(p => p.InternationalStatuses)
                .Include(p => p.Liquidations)
                .SingleOrDefaultAsync(a => a.Id == id);

            return protectedArea;
        }
    }
}