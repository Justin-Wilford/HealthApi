namespace HealthApi;

public interface IHeartRateRepository
{
    Task<HeartRate> GetHeartRateByIdAsync(int HeartRateId);
    Task<HeartRate> GetAverageHeartRateAsync(DateTime dateTime);
    Task AddHeartRateAsync(HeartRate heartRate);
    Task DeleteHeartRateAsync(int HeartRateId);
}