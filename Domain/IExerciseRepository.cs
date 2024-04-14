namespace HealthApi;

public interface IExerciseRepository
{
    Task AddExerciseAsync(Exercise exercise);
    Task<Exercise?> FindAllByDateAsync(DateTime dateTime);
    Task<Exercise?> FindByIdAsync(int ExerciseId);
    Task DeleteExerciseAsync(int ExerciseId);
}