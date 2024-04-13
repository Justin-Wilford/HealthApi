using HealthApi.Application;

namespace HealthApi.Infrastructure;

public sealed class DapperWaterIntakeRepository : IWaterIntakeRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperWaterIntakeRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    // add methods
}