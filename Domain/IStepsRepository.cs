namespace HealthApi;

public interface IStepsRepository
{
    Task AddStepsAsync(Steps steps);
    Task<List<Steps?>> FindAllByDateAsync(DateTime StepDate, int UserId);
    Task<Steps?> FindByIdAsync(int StepId);
    Task DeleteStepsAsync(int StepId);
}