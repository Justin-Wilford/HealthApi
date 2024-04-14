using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Queries;

public sealed class FindAllExercisesByDateQuery : HttpEndpoint
{
    [HttpGet("Exercises/{ExerciseDate}")]
    public async Task<List<Exercise>> ExecuteAsync(
        DateTime ExerciseDate,
        [FromServices] IExerciseRepository exerciseRepository)
    {
        var albums = exerciseRepository.FindAllByDateAsync(ExerciseDate);

        return await albums;
    }
}