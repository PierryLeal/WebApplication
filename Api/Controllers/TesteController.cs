using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.Application.Interfaces;
using WebApplication.Domain.entities;
using WebApplication.Infastructure.Persistence;

namespace WebApplication.Api.Controllers
{
    [ApiController]
    [Route("teste")]
    public class TesteController : ControllerBase
    {
        private readonly ITesteService _testeService;

        public TesteController(ITesteService testeService)
        {
            _testeService = testeService;
        }

        [HttpGet()]
        public Task<List<Teste>> Get()
        {
            var teste = _testeService.GetAllTestes();
            return teste;
        }

        [HttpGet("{id}")]
        public Task<Teste> GetById([FromRoute] int id)
        {

            return _testeService.GetByIdTeste(id);
        }
    }
}
