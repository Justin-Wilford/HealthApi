namespace HealthApi;

public interface IStepsRepository
{
    Task AddStepsAsync(Steps steps);
    Task<Steps?> FindAllByDateAsync(DateTime dateTime);
    Task<Steps?> FindByIdAsync(int StepId);
    Task DeleteStepsAsync(int StepId);
}