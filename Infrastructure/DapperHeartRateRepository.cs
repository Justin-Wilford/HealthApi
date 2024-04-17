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

    public async Task<int> GetAverageHeartRateAsync(DateTime heartRateDate, int userId)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
            
            var query = await connection.QuerySingleAsync<int>("SELECT AVG(AverageHeartRate) AverageHeartRate FROM HeartRate " + 
                "where UserId = @UserId AND HeartRateDate = @HeartRateDate", new { HeartRateDate = heartRateDate, UserId = userId });

            return query;
        }
    }

    public async Task AddHeartRateAsync(HeartRate heartRate)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
        
            var sql = "INSERT INTO HeartRate (AverageHeartRate, UserId, HeartRateDate) VALUES (@AverageHeartRate, @UserId, @HeartRateDate)";
            connection.Execute(sql, heartRate);
        }
    }

    public async Task DeleteHeartRateAsync(int heartRateId)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
            
            connection.Execute(
                "DELETE FROM HeartRate WHERE HeartRateId = @HeartRateId", new { HeartRateId = heartRateId });
        }    
    }
}