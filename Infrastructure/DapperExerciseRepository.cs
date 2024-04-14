using HealthApi.Application;
using Dapper;
using Microsoft.Data.SqlClient;

namespace HealthApi.Infrastructure;

public sealed class DapperExerciseRepository : IExerciseRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperExerciseRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public async Task AddExerciseAsync(Exercise exercise)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
        
            var sql = "INSERT INTO Exercise (TotalTime, Run, Walk, Bike, Hike, UserId, ExerciseDate) VALUES (@TotalTime, @Run, @Walk, @Bike, @Hike, @UserId, @ExerciseDate)";
            connection.Execute(sql, exercise);
        }
    }

    public async Task<List<Exercise>> FindAllByDateAsync(DateTime dateTime)
    {
        await using var connection = new SqlConnection(_databaseOptions.ConnectionString);
        
        await connection.OpenAsync();

        var query = await connection.QueryAsync<Exercise>("SELECT * FROM Exercise Where ExerciseDate = @ExerciseDate", new {ExerciseDate = dateTime});

        return query.ToList();
    }

    public async Task<Exercise> FindByIdAsync(int ExerciseId)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteExerciseAsync(int exerciseId)
    {
        throw new NotImplementedException();
    }
}