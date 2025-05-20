using MediatR;
using RepertorioBack.Aplication.Dtos;

namespace RepertorioBack.Aplication.Commands.Update
{
    public class UpdateMusicaCommad : IRequest<MusicaDto>
    {
        public int Id { get; set; } 
        public MusicaDto MusicaRequest { get; set; }
        public UpdateMusicaCommad(int id, MusicaDto musicaDto) 
        { 
            Id = id;
            MusicaRequest = musicaDto;
        }
    }
}
