using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Commands;

public sealed class AddExerciseCommand : HttpEndpoint
{
    [HttpPost("exercise")]
    public async Task ExecuteAsync(
        [FromServices] IExerciseRepository exerciseRepository,
        [FromBody] Exercise exercise)
    {
        await exerciseRepository.AddExerciseAsync(exercise);
    }
}