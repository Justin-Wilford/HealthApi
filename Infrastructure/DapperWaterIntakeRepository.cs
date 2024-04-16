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
        throw new NotImplementedException();
    }

    public async Task DeleteWaterAsync(int waterIntakeId)
    {
        throw new NotImplementedException();
    }
}