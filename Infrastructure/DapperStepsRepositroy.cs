using Dapper;
using HealthApi.Application;
using Microsoft.Data.SqlClient;

namespace HealthApi.Infrastructure;

public sealed class DapperStepsRepository : IStepsRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperStepsRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public async Task AddStepsAsync(Steps steps)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
        
            var sql = "INSERT INTO Steps (StepsTaken, Miles, UserId, StepDate) VALUES (@StepsTaken, @Miles, @UserId, @StepDate)";
            connection.Execute(sql, steps);
        }    }

    public async Task<Steps> FindAllByDateAsync(DateTime date)
    {
        throw new NotImplementedException();
    }

    public async Task<Steps> FindByIdAsync(int stepId)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
            
            var query = await connection.QuerySingleAsync<Steps>("SELECT * FROM Steps WHERE StepId = @StepId", new {StepId = stepId});

            return query;
        }
    }

    public async Task DeleteStepsAsync(int StepId)
    {
        throw new NotImplementedException();
    }
}