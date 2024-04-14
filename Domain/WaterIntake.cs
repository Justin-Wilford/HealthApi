namespace HealthApi;

public class WaterIntake
{
    public int WaterIntakeId { get; set; }
    public int DailyWaterIntake { get; set; }
    public int UserId { get; set; }
    public DateTime WaterIntakeDate { get; set; }
}