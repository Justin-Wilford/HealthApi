using Dapper;
using HealthApi.Application;
using Microsoft.Data.SqlClient;

namespace HealthApi.Infrastructure;

public sealed class DapperWaterIntakeRepository : IWaterIntakeRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperWaterIntakeRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public async Task AddWaterAsync(WaterIntake waterIntake)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
        
            var sql = "INSERT INTO WaterIntake (DailyWaterIntake, UserId, WaterIntakeDate) VALUES (@DailyWaterIntake, @UserId, @WaterIntakeDate)";
            connection.Execute(sql, waterIntake);
        }
    }

    public async Task<WaterIntake?> FindAllByDateAsync(DateTime date)
    {
        throw new NotImplementedException();
    }

    public async Task<WaterIntake?> FindByIdAsync(int waterIntakeId)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
            
            var query = await connection.QuerySingleAsync<WaterIntake>("SELECT * FROM WaterIntake WHERE WaterIntakeId = @WaterIntakeId", new {WaterIntakeId = waterIntakeId});

            return query;
        }
    }

    public async Task DeleteWaterAsync(int waterIntakeId)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
            
            connection.Execute(
                "DELETE FROM WaterIntake WHERE WaterIntakeId = @WaterIntakeId", new { WaterIntakeId = waterIntakeId });
        }
    }
}