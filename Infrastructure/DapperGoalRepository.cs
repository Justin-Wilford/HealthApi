using Dapper;
using HealthApi.Application;
using Microsoft.Data.SqlClient;

namespace HealthApi.Infrastructure;

public sealed class DapperGoalRepository : IGoalRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperGoalRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public async Task<Goals> GetGoalsAsync(int userId)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
            
            var query = await connection.QuerySingleAsync<Goals>("SELECT * FROM Goals WHERE UserId = @UserId", new {UserId = userId});

            return query;
        }
    }

    public async Task UpdateGoalsAsync(Goals goals)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();

            var sql = @"UPDATE Goals SET
                            StepGoal = @StepGoal,
                            WaterIntakeGoal = @WaterIntakeGoal
                        WHERE UserId = @UserId";

            await connection.ExecuteAsync(sql, goals);
        }
    }
}