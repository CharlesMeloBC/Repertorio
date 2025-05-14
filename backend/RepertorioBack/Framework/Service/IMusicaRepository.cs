using Microsoft.AspNetCore.Mvc;
using RepertorioBack.Domain.Models;

namespace RepertorioBack.Framework.Service
{
    public interface IMusicaRepository
    {
        Task<IEnumerable<MusicaAgregate>> GetAllMusicasAsync();
        Task<MusicaAgregate> GetMusicaByIdAsync(int id);
        Task<MusicaAgregate> PostMusic(MusicaAgregate model);
        Task<MusicaAgregate> UpdateMusic(int id, MusicaAgregate model);
        Task<bool> DeleteMusic(int Id);

    }

}
