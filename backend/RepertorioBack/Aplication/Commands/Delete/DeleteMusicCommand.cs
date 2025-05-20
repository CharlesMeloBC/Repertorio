using MediatR;
using RepertorioBack.Aplication.Dtos;

namespace RepertorioBack.Aplication.Commands.Delete
{
    public class DeleteMusicCommand : IRequest<MusicaDto>
    {
        public int Id { get; set; } 
        public DeleteMusicCommand(int id) 
        { 
            Id = id;
        }
    }
}
