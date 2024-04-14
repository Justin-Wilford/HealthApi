namespace HealthApi;

public class Steps
{
    public int StepId { get; set; }
    public int StepsTaken { get; set; }
    public decimal Miles { get; set; }
    public DateTime StepDate { get; set; }
    public int UserId { get; set; }
}