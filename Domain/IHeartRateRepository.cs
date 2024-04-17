namespace HealthApi;

public interface IHeartRateRepository
{
    Task<HeartRate> GetHeartRateByIdAsync(int HeartRateId);
    Task<int> GetAverageHeartRateAsync(DateTime heartRateDate, int UserId);
    Task AddHeartRateAsync(HeartRate heartRate);
    Task DeleteHeartRateAsync(int HeartRateId);
}