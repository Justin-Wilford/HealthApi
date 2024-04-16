using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Commands;

public sealed class DeleteStepsCommand : HttpEndpoint
{
    [HttpDelete("steps/{id}")]
    public async Task ExecuteAsync(
        [FromServices] IStepsRepository stepsRepository,
        [FromRoute] int id)
    {
        await stepsRepository.DeleteStepsAsync(id);
    }
}