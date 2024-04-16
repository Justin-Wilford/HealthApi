using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Commands;

public sealed class UpdateUserCommand : HttpEndpoint
{
    [HttpPut("users/{id}")]
    public async Task ExecuteAsync(
        [FromServices] IUsersRepository usersRepository,
        [FromRoute] int id,
        [FromBody] Users users)
    {
        await usersRepository.UpdateUserAsync(users);
    }
}