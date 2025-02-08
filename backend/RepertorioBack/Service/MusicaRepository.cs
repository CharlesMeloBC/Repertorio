using Dapper;
using Microsoft.Data.SqlClient;
using RepertorioBack.Models;
using RepertorioBack.Service;
using System.Data;

public class MusicaRepository : IMusicaRepository
{
    private readonly string _connectionString;

    public MusicaRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection Connection => new SqlConnection(_connectionString);

    public async Task<IEnumerable<MusicaModel>> GetAllMusicasAsync()
    {
        using (var connection = Connection)
        {
            var query = "SELECT * FROM LOUVORES"; 
            return await connection.QueryAsync<MusicaModel>(query);
        }
    }

    public async Task<MusicaModel> GetMusicaByIdAsync(int id)
    {
        using (var connection = Connection)
        {
            var query = "SELECT * FROM LOUVORES WHERE Id = @Id";
            return await connection.QueryFirstOrDefaultAsync<MusicaModel>(query, new { Id = id });
        }
    }

    public async Task<MusicaModel> PostMusic (MusicaModel model)
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

}
