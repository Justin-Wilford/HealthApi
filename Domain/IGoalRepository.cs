namespace HealthApi;

public interface IGoalRepository
{
    Task<Goals> GetGoalsAsync(int UserId);
    Task UpdateGoalsAsync(int UserId);
}