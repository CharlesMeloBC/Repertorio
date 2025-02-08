using Microsoft.AspNetCore.Mvc;
using RepertorioBack.Models;
using RepertorioBack.Service;

namespace RepertorioBack.Controllers
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
                return BadRequest("Música não fornecida");
            }

            var musicaCriada = await _musicaRepository.PostMusic(musica);

            return CreatedAtAction(nameof(GetById), new { id = musicaCriada.Id }, musicaCriada);
        }
    }
}
