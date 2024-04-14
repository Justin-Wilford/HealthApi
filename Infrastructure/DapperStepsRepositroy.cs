using HealthApi.Application;

namespace HealthApi.Infrastructure;

public sealed class DapperStepsRepository : IStepsRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperStepsRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public async Task AddStepsAsync(Steps steps)
    {
        throw new NotImplementedException();
    }

    public async Task<Steps> FindAllByDateAsync(DateTime date)
    {
        throw new NotImplementedException();
    }

    public async Task<Steps> FindByIdAsync(int StepId)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteStepsAsync(int StepId)
    {
        throw new NotImplementedException();
    }
}