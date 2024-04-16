using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Queries;

public sealed class FindAllUsersQuery : HttpEndpoint
{
    [HttpGet("users")]
    public async Task<List<Users>> ExecuteAsync(
        [FromServices] IUsersRepository usersRepository)
    {
        var users = usersRepository.FindAllUsersAsync();

        return await users;
    }
}