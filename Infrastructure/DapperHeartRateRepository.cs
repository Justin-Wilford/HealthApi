using Dapper;
using HealthApi.Application;
using Microsoft.Data.SqlClient;

namespace HealthApi.Infrastructure;

public sealed class DapperHeartRateRepository : IHeartRateRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperHeartRateRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public async Task<HeartRate> GetHeartRateByIdAsync(int heartRateId)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
            
            var query = await connection.QuerySingleAsync<HeartRate>("SELECT * FROM HeartRate WHERE HeartRateId = @HeartRateId", new {HeartRateId = heartRateId});

            return query;
        } 
    }

    public async Task<HeartRate> GetAverageHeartRateAsync(DateTime dateTime)
    {
        throw new NotSupportedException();
    }

    public async Task AddHeartRateAsync(HeartRate heartRate)
    {
        throw new NotFiniteNumberException();
    }

    public async Task DeleteHeartRateAsync(int HeartRateId)
    {
        throw new NotImplementedException();
    }
}