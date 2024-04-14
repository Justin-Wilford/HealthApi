using HealthApi.Application;

namespace HealthApi.Infrastructure;

public sealed class DapperHeartRateRepository : IHeartRateRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperHeartRateRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public async Task<HeartRate> GetHeartRateByIdAsync(int HeartRateId)
    {
        throw new NotImplementedException();
    }

    public async Task<HeartRate> GetAverageHeartRateAsync(DateTime dateTime)
    {
        throw new NotSupportedException();
    }

    public async Task AddHeartRateAsync(HeartRate heartRate)
    {
        throw new NotFiniteNumberException();
    }

    public async Task DeleteHeartRateAsync(int HeartRateId)
    {
        throw new NotImplementedException();
    }
}