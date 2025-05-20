using MediatR;
using RepertorioBack.Aplication.Dtos;

namespace RepertorioBack.Aplication.Querys
{
    public class GetMusicByIdQueryHandler : IRequestHandler<GetMusicByIdQuery, MusicaDto>
    {
        public GetMusicByIdQueryHandler() { }

        public Task<MusicaDto> Handle(GetMusicByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
