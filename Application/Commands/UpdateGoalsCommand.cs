using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Commands;

public sealed class UpdateGoalsCommand : HttpEndpoint
{
    [HttpPut("albums/{id}")]
    public async Task ExecuteAsync(
        [FromServices] IGoalRepository goalRepository,
        [FromRoute] int id,
        [FromBody] Goals goals)
    {
        await goalRepository.UpdateGoalsAsync(goals);
    }
}