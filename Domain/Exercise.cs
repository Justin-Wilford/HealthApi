namespace HealthApi;

public class Exercise
{
    public int ExerciseId { get; set; }
    public int TotalTime { get; set; }
    public int Run { get; set; }
    public int Walk { get; set; }
    public int Bike { get; set; }
    public int Hike { get; set; }
    public int UserId { get; set; }
    public DateTime ExerciseDate { get; set; }
}