using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Commands;

public sealed class AddUserCommand : HttpEndpoint
{
    [HttpPost("users")]
    public async Task ExecuteAsync(
        [FromServices] IUsersRepository usersRepository,
        [FromBody] Users user)
    {
        await usersRepository.AddUserAsync(user);
    }
}