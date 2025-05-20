using MediatR;
using RepertorioBack.Aplication.Dtos;

namespace RepertorioBack.Aplication.Commands.Create
{
    public class CreateMusicCommand : IRequest<MusicaDto>
    {
        public MusicaDto MusicaRequest { get; set; }

        public CreateMusicCommand(MusicaDto musicaRequest)
        {
            MusicaRequest = musicaRequest;
        }
    }
}
