using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Commands;

public sealed class AddStepsCommand : HttpEndpoint
{
    [HttpPost("steps")]
    public async Task ExecuteAsync(
        [FromServices] IStepsRepository stepsRepository,
        [FromBody] Steps steps)
    {
        await stepsRepository.AddStepsAsync(steps);
    }
}