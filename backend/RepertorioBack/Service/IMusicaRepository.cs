using Microsoft.AspNetCore.Mvc;
using RepertorioBack.Models;

namespace RepertorioBack.Service
{
    public interface IMusicaRepository
    {
        Task<IEnumerable<MusicaModel>> GetAllMusicasAsync();
        Task<MusicaModel> GetMusicaByIdAsync(int id);
        Task<MusicaModel> PostMusic (MusicaModel model);
        Task<MusicaModel> UpdateMusic (int id, MusicaModel model);
        Task<bool> DeleteMusic(int Id);

    }

}
