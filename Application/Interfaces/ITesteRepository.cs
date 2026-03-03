using WebApplication.Domain.entities;

namespace WebApplication.Application.Interfaces
{
    public interface ITesteRepository
    {
        Task<List<Teste>> GetAllAsync();
        Task<Teste> GetByIdAsync(int id);
    }
}
