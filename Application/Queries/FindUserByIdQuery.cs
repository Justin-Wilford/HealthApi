using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Queries;

public sealed class FindUserByIdQuery : HttpEndpoint
{
    [HttpGet("Users/{UserId}")]
    public async Task<Users?> ExecuteAsync(
        [FromServices] IUsersRepository usersRepository,
        [FromRoute] int UserId)
    {
        var user = usersRepository.FindUserByIdAsync(UserId);

        return await user;
    }
}