using RepertorioBack.Aplication.Dtos;

namespace RepertorioBack.Aplication.Querys
{
    public interface IGetMusicaQueryHandler
    {
        Task<List<MusicaDto>> Handle(GetMusicaQueryHandler request, CancellationToken cancellationToken);
    }
}