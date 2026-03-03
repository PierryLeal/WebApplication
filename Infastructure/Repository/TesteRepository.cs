using Microsoft.EntityFrameworkCore;
using WebApplication.Application.Interfaces;
using WebApplication.Domain.entities;
using WebApplication.Infastructure.Persistence;

namespace WebApplication.Infastructure.Repository
{
    public class TesteRepository: ITesteRepository
    {
        private readonly AppDbContext _context;

        public TesteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Teste>> GetAllAsync()
        {
            return await _context.teste.ToListAsync();
        }

        public async Task<Teste> GetByIdAsync(int id)
        {
            return await _context.teste.FirstOrDefaultAsync(t => t.Id == id) ?? new Teste { };
        }
    }
}
