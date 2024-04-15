using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Queries;

public sealed class GetGoalsQuery : HttpEndpoint
{
    [HttpGet("Goals/{UserId}")]
    public async Task<Goals?> ExecuteAsync(
        [FromServices] IGoalRepository goalRepository,
        [FromRoute] int UserId)
    {
        var goals = goalRepository.GetGoalsAsync(UserId);

        return await goals;
    }
}