using MediatR;
using RepertorioBack.Aplication.Dtos;

namespace RepertorioBack.Aplication.Commands.Delete
{
    public class DeleteMusicCommandHandler : IRequestHandler<DeleteMusicCommand, MusicaDto>
    {
        public DeleteMusicCommandHandler() 
        { }

        public Task<MusicaDto> Handle(DeleteMusicCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
