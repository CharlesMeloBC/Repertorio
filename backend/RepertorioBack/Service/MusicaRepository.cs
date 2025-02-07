// MusicaRepository.cs
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using RepertorioBack.Models;
using RepertorioBack.Service;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

public class MusicaRepository : IMusicaRepository
{
    private readonly string _connectionString;

    public MusicaRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection Connection => new SqlConnection(_connectionString);

    // Método para obter todas as músicas
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

}
