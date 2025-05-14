using Dapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepertorioBack.Domain.Models;
using RepertorioBack.Framework.Service;
using System.Data;

public class MusicaRepository : IMusicaRepository
{
    private readonly string _connectionString;

    public MusicaRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection Connection => new SqlConnection(_connectionString);

    public async Task<IEnumerable<MusicaAgregate>> GetAllMusicasAsync()
    {
        using (var connection = Connection)
        {
            var query = "SELECT * FROM LOUVORES"; 
            return await connection.QueryAsync<MusicaAgregate>(query);
        }
    }

    public async Task<MusicaAgregate> GetMusicaByIdAsync(int id)
    {
        using (var connection = Connection)
        {
            var query = "SELECT * FROM LOUVORES WHERE Id = @Id";
            return await connection.QueryFirstOrDefaultAsync<MusicaAgregate>(query, new { Id = id });
        }
    }

    public async Task<MusicaAgregate> PostMusic (MusicaAgregate model)
    {
        using(var connection = Connection)
        {
            var query = @"
            INSERT INTO LOUVORES (Nome, Artista, Tipo, Quantidade)
            VALUES (@Nome, @Artista, @Tipo, @Quantidade);
            SELECT CAST(SCOPE_IDENTITY() AS INT);"; 

            var id = await connection.ExecuteScalarAsync<int>(query, new
            {
                Nome = model.Nome,
                Artista = model.Artista,
                Tipo = model.Tipo,
                Quantidade = model.Quantidade,
            });

            model.Id = id;
            return model;
        }
    }

    public async Task<bool> DeleteMusic(int Id)
    {
        using (var connection = Connection)
        {
            var query = "DELETE FROM LOUVORES WHERE Id = @Id";

            var result = await connection.ExecuteAsync(query, new { Id });

            return result > 0;
        }
    }

    public async Task<MusicaAgregate> UpdateMusic(int id, MusicaAgregate model)
    {
        using (var connection = Connection)
        {
            var query = @"
            UPDATE LOUVORES
            SET Nome = @Nome,
                Artista = @Artista,
                Tipo = @Tipo,
                Quantidade = @Quantidade
            WHERE Id = @Id;
            
            SELECT * FROM LOUVORES WHERE Id = @Id;
        ";

            var musicaAtualizada = await connection.QuerySingleOrDefaultAsync<MusicaAgregate>(query, new
            {
                Id = id,
                Nome = model.Nome,
                Artista = model.Artista,
                Tipo = model.Tipo,
                Quantidade = model.Quantidade
            });

            return musicaAtualizada;
        }
    }

}