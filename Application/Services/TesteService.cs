using WebApplication.Application.Interfaces;
using WebApplication.Domain.entities;

namespace WebApplication.Application.Services
{
    public class TesteService: ITesteService
    {
        private readonly ITesteRepository _testeRepository;

        public TesteService(ITesteRepository testeRepository)
        {
            _testeRepository = testeRepository;
        }

        public Task<List<Teste>> GetAllTestes()
        {
            return _testeRepository.GetAllAsync();
        }
       
        public Task<Teste> GetByIdTeste(int id)
        {
            return _testeRepository.GetByIdAsync(id);
        }
    }
}
