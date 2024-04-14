using HealthApi.Application;

namespace HealthApi.Infrastructure;

public sealed class DapperHeartRateRepository : IHeartRateRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperHeartRateRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public Task<HeartRate> GetHeartRateByIdAsync(int HeartRateId)
    {
        throw new NotImplementedException();
    }

    public Task<HeartRate> GetAverageHeartRateAsync(DateTime dateTime)
    {
        throw new NotSupportedException();
    }

    public Task AddHeartRateAsync(HeartRate heartRate)
    {
        throw new NotFiniteNumberException();
    }

    public Task DeleteHeartRateAsync(int HeartRateId)
    {
        throw new NotImplementedException();
    }
}