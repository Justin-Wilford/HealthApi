using HealthApi.Application;

namespace HealthApi.Infrastructure;

public sealed class DapperExerciseRepository : IExerciseRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperExerciseRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    // add methods
}