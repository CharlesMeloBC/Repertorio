using AutoMapper;
using MediatR;
using RepertorioBack.Aplication.Dtos;

namespace RepertorioBack.Aplication.Commands.Create
{
    public class CreatePlaylistCommandHandler : IRequestHandler<CreatePlaylistCommand, List<MusicaDto>>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CreatePlaylistCommandHandler(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }
        public Task<List<MusicaDto>> Handle(CreatePlaylistCommand request, CancellationToken cancellationToken)
        {


            return _mapper.Map<List<MusicaDto>>();
        }
    }
}
