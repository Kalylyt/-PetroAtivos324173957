using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetroAtivos324173957.Data;
using PetroAtivos324173957.Models;

namespace PetroAtivos324173957.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtivosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AtivosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ativo>>> ListarAtivos()
        {
            var ativos = await _context.Ativos.ToListAsync();

            return Ok(ativos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ativo>> BuscarAtivoPorId(int id)
        {
            var ativo = await _context.Ativos.FindAsync(id);

            if (ativo == null)
            {
                return NotFound("Ativo não encontrado.");
            }

            return Ok(ativo);
        }

        [HttpPost]
        public async Task<ActionResult<Ativo>> CadastrarAtivo(Ativo ativo)
        {
            _context.Ativos.Add(ativo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(BuscarAtivoPorId), new { id = ativo.Id }, ativo);
        }
    }
}