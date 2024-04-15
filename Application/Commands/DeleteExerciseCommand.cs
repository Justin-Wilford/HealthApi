using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Commands;

public sealed class DeleteExerciseCommand : HttpEndpoint
{
    [HttpDelete("albums/{id}")]
    public async Task ExecuteAsync(
        [FromServices] IExerciseRepository exerciseRepository,
        [FromRoute] int id)
    {
        await exerciseRepository.DeleteExerciseAsync(id);
    }
}