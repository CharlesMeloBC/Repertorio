using System.ComponentModel.DataAnnotations;

namespace RepertorioBack.Domain.Models
{
    public class MusicaAgregate
    {
        public int? Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string? Artista { get; private set; }
        public int? Quantidade { get; private set; }
        public string? Tipo { get; private set; }
        public MusicaAgregate(){}

        public MusicaAgregate(int? id, string nome, string? artista, int? quantidade, string? tipo)
        {
            Id = id;
            Nome = nome;
            Artista = artista;
            Quantidade = quantidade;
            Tipo = tipo;
        }
    }
}
