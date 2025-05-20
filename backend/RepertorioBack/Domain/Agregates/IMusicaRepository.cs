using RepertorioBack.Aplication.Dtos;
using RepertorioBack.Domain.Models;

namespace RepertorioBack.Domain.Agregates
{
    public interface IMusicaRepository 
    {
        Task<IEnumerable<MusicaAgregate>> GetAllMusicasAsync();
        Task<MusicaAgregate> GetMusicaByIdAsync(int id);
        Task<MusicaDto> PostMusic(MusicaDto model);
        Task<MusicaAgregate> UpdateMusic(int id, MusicaAgregate model);
        Task<bool> DeleteMusic(int Id);
        Task<List<MusicaDto>> CreatePlaylist (List<MusicaDto> playlist); 
    }
}
