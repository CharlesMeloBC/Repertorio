using MediatR;
using RepertorioBack.Aplication.Dtos;


namespace RepertorioBack.Aplication.Commands.Create
{
    public class CreatePlaylistCommand : IRequest<List<MusicaDto>>
    {
        public List<MusicaDto> Playlist { get; set; }

        public CreatePlaylistCommand(List<MusicaDto> musica)
        {
            Playlist = musica;
        }
    }

}
