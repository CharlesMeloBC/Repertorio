namespace RepertorioBack.Aplication.Dtos
{
    public class MusicaDto
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string? Artista { get; set; }
        public int? Quantidade { get; set; }
        public string? Tipo { get; set; }
    }
}
