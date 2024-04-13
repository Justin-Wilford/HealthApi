using HealthApi.Application;

namespace HealthApi.Infrastructure;

public sealed class DapperGoalRepository : IGoalRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperGoalRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    // add methods
}