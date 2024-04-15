using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Queries;

public sealed class FindStepsByIdQuery : HttpEndpoint
{
    [HttpGet("Steps/{StepId}")]
    public async Task<Steps?> ExecuteAsync(
        [FromServices] IStepsRepository stepRepository,
        [FromRoute] int StepId)
    {
        var steps = stepRepository.FindByIdAsync(StepId);

        return await steps;
    }
}