using HealthApi.Application;

namespace HealthApi.Infrastructure;

public sealed class DapperStepsRepository : IStepsRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperStepsRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    // add methods
}