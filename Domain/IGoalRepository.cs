namespace HealthApi;

public interface IGoalRepository
{
    Task<Goals> GetGoalsAsync(int GoalId);
    Task UpdateGoalsAsync(int GoalId);
}