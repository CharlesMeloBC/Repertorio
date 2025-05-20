using AutoMapper;
using MediatR;
using RepertorioBack.Aplication.Dtos;
using RepertorioBack.Domain.Agregates;

namespace RepertorioBack.Aplication.Commands.Create
{
    public class CreateMusicCommandHandler : IRequestHandler<CreateMusicCommand, MusicaDto>
    {
        private readonly IMapper _mapper;
        private readonly IMusicaRepository _musicaRepository;
        public CreateMusicCommandHandler(IMusicaRepository musicaRepository, IMapper mapper)
        { 
            _mapper = mapper;
            _musicaRepository = musicaRepository;   
        }
        public async Task<MusicaDto> Handle(CreateMusicCommand request, CancellationToken cancellationToken)
        {
            var musica = new MusicaDto
            {
                Nome = request.MusicaRequest.Nome,
                Artista = request.MusicaRequest.Artista,
                Quantidade = request.MusicaRequest.Quantidade,
                Tipo = request.MusicaRequest.Tipo,
            };

            await _musicaRepository.PostMusic(musica);
            return _mapper.Map<MusicaDto>(musica);
        }
    }
}
