using HealthApi.Application;

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
        throw new NotImplementedException();
    }

    public async Task<Exercise> FindAllByDateAsync(DateTime dateTime)
    {
        throw new NotImplementedException();
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