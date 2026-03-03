using WebApplication.Domain.entities;

namespace WebApplication.Application.Interfaces
{
    public interface ITesteService
    {
        Task<List<Teste>> GetAllTestes();
        Task<Teste> GetByIdTeste(int id);
    }
}
