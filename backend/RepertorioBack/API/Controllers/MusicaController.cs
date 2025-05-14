using Microsoft.AspNetCore.Mvc;
using RepertorioBack.Domain.Models;
using RepertorioBack.Framework.Service;

namespace RepertorioBack.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicaController : ControllerBase
    {
        private readonly IMusicaRepository _musicaRepository;

        public MusicaController(IMusicaRepository musicaRepository)
        {
            _musicaRepository = musicaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MusicaModel>>> GetAll()
        {
            var musicas = await _musicaRepository.GetAllMusicasAsync();
            return Ok(musicas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MusicaModel>> GetById(int id)
        {
            var musica = await _musicaRepository.GetMusicaByIdAsync(id);
            if (musica == null)
            {
                return NotFound();
            }

            return Ok(musica);
        }

        [HttpPost]
        public async Task<IActionResult> PostMusica([FromBody] MusicaModel musica)
        {
            if (musica == null)
            {
                return BadRequest("Música não cadastrada");
            }

            var musicaCriada = await _musicaRepository.PostMusic(musica);

            return CreatedAtAction(nameof(GetById), new { id = musicaCriada.Id }, musicaCriada);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusic(int Id)
        {
            var musica = await _musicaRepository.DeleteMusic(Id);

            if (musica)
            {
                return NoContent();
            }

            return NotFound(new { musica = "Erro ao tentar excluir" });

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMusic(int id, [FromBody] MusicaModel musica)
        {
            if (musica == null)
            {
                return BadRequest("Música não fornecida.");
            }

            var musicaAtualizada = await _musicaRepository.UpdateMusic(id, musica);

            if (musicaAtualizada == null)
            {
                return NotFound(new { mensagem = "Música não encontrada para atualizar." });
            }

            return Ok(musicaAtualizada);
        }

    }
}
