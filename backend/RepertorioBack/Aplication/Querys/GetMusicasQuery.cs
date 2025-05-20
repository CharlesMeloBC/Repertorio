using MediatR;
using RepertorioBack.Aplication.Dtos;

namespace RepertorioBack.Aplication.Querys
{
    public class GetMusicasQuery : IRequest<List<MusicaDto>>
    {
        public GetMusicasQuery() { }
    }
}
