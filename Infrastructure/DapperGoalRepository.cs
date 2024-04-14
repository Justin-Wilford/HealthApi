using HealthApi.Application;

namespace HealthApi.Infrastructure;

public sealed class DapperGoalRepository : IGoalRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperGoalRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public async Task<Goals> GetGoalsAsync(int GoalId)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateGoalsAsync(int GoalId)
    {

    }
}