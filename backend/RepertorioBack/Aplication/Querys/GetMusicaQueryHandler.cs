using MediatR;
using RepertorioBack.Aplication.Dtos;

namespace RepertorioBack.Aplication.Querys
{
    public class GetMusicaQueryHandler : IRequestHandler<GetMusicasQuery, List<MusicaDto>>
    {
        public GetMusicaQueryHandler() 
        { }

        public Task<List<MusicaDto>> Handle(GetMusicasQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
