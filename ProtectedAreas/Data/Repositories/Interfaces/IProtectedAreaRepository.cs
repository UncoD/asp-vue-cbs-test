using System.Threading.Tasks;
using ProtectedAreas.Models;

namespace ProtectedAreas.Data.Repositories.Interfaces
{
    public interface IProtectedAreaRepository
    {
        Task<ProtectedArea> GetAsync(int id);
    }
}