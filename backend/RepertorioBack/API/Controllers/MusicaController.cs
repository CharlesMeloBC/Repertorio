using Microsoft.AspNetCore.Mvc;
using RepertorioBack.Aplication.Commands.Create;
using RepertorioBack.Aplication.Commands.Delete;
using RepertorioBack.Aplication.Commands.Update;
using RepertorioBack.Aplication.Dtos;
using RepertorioBack.Aplication.Querys;
using RepertorioBack.Domain.Models;

namespace RepertorioBack.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicaController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MusicaAgregate>>> GetAll()
        {
            var query = new GetMusicasQuery();

            return Ok(query);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MusicaAgregate>> GetById(int id)
        {
            var query = new GetMusicByIdQuery(id);
            if (query == null)
            {
                return NotFound();
            }

            return Ok(query);
        }

        [HttpPost]
        public async Task<IActionResult> PostMusica([FromBody] MusicaAgregate musica)
        {

           var command = new CreateMusicCommand(musica.Nome, musica.Artista, musica.Quantidade, musica.Tipo);

            if (musica == null)
            {
                return BadRequest("Música não cadastrada");
            }

            return Ok(command);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusic(int id)
        {
            var command = new DeleteMusicCommand(id);

            if (command != null)
            {
                return NotFound(new { musica = "Erro ao tentar excluir" });
            }

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMusic(int id, [FromBody] MusicaDto musica)
        {
            var command = new UpdateMusicaCommad(id, musica);

            if (command == null)
            {
                return NotFound(new { mensagem = "Música não encontrada para atualizar." });
            }

            return Ok(command);
        }
    }
}
