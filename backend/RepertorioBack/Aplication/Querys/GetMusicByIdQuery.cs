using MediatR;

namespace RepertorioBack.Aplication.Querys
{
    public class GetMusicByIdQuery : IRequest<GetMusicByIdQuery>
    {
        public int Id { get; set; }
        public GetMusicByIdQuery(int id) 
        { 
            Id = id;
        }
    }
}
