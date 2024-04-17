using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Queries;

public sealed class FindAllExercisesByDateQuery : HttpEndpoint
{
    [HttpGet("Exercises")]
    public async Task<List<Exercise>> ExecuteAsync(
        [FromQuery] DateTime ExerciseDate,
        [FromQuery] int UserId,
        [FromServices] IExerciseRepository exerciseRepository)
    {
        var albums = exerciseRepository.FindAllByDateAsync(ExerciseDate, UserId);

        return await albums;
    }
}