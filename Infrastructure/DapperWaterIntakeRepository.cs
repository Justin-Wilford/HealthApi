using HealthApi.Application;

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
        throw new NotImplementedException();
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