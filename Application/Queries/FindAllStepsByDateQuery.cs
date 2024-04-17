using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Queries;

public sealed class FindStepsByDateQuery : HttpEndpoint
{
    [HttpGet("Steps")]
    public async Task<List<Steps?>> ExecuteAsync(
        [FromServices] IStepsRepository stepsRepository,
        [FromQuery] DateTime StepDate,
        [FromQuery] int UserId)
    {
        var waterIntake = stepsRepository.FindAllByDateAsync(StepDate, UserId);

        return await waterIntake;
    }
}