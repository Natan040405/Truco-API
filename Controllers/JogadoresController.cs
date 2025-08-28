using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Truco_API.Data;
using Truco_API.Models;

namespace Truco_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadoresController : ControllerBase
    {
        private readonly AppDbContext _AppDbcontext;

        public JogadoresController(AppDbContext appDbcontext)
        {
            _AppDbcontext = appDbcontext;
        }

        [HttpPost]
        public async Task<IActionResult> AddJogador(Jogador jogador)
        {
            _AppDbcontext.Jogadores.Add(jogador);
            await _AppDbcontext.SaveChangesAsync();
            return Ok(jogador);
        }
        [HttpGet] 
        public async Task<ActionResult<IEnumerable<Jogador>>> GetJogador()
        {
            List<Jogador> jogadores = await _AppDbcontext.Jogadores.ToListAsync();
            return Ok(jogadores);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Jogador>> GetJogadorById(int id)
        {
            Jogador jogador = await _AppDbcontext.Jogadores.FindAsync(id);
            return Ok(jogador);
        }
    }
}
