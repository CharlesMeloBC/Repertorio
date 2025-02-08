using RepertorioBack.Models;

namespace RepertorioBack.Service
{
    public interface IMusicaRepository
    {
        Task<IEnumerable<MusicaModel>> GetAllMusicasAsync();
        Task<MusicaModel> GetMusicaByIdAsync(int id);
        Task<MusicaModel> PostMusic (MusicaModel model);

    }

}
