using MediatR;
using RepertorioBack.Aplication.Dtos;

namespace RepertorioBack.Aplication.Commands.Update
{
    public class UpdateMusicaCommadHandler : IRequestHandler<UpdateMusicaCommad, MusicaDto>
    {
        public UpdateMusicaCommadHandler()
        {

        }
        public Task<MusicaDto> Handle(UpdateMusicaCommad request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
