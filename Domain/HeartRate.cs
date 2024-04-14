namespace HealthApi;

public class HeartRate
{
    public int HeartRateId { get; set; }
    public int AverageHeartRate { get; set; }
    public int UserId { get; set; }
    public DateTime HeartRateDate { get; set; }
}