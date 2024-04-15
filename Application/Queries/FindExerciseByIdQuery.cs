using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Queries;

public sealed class FindExerciseByIdQuery : HttpEndpoint
{
    [HttpGet("Exercise/{ExerciseId}")]
    public async Task<Exercise?> ExecuteAsync(
        [FromServices] IExerciseRepository exerciseRepository,
        [FromRoute] int ExerciseId)
    {
        var exercise = exerciseRepository.FindByIdAsync(ExerciseId);

        return await exercise;
    }
}