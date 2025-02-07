using System.ComponentModel.DataAnnotations;

namespace RepertorioBack.Models
{
    public class MusicaModel
    {
        public int? Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Artista { get; set; }
        public int? Quantidade { get; set; }
        public string? Tipo { get; set; }
    }
}
