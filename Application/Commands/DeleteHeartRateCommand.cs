using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Commands;

public sealed class DeleteHeartRateCommand : HttpEndpoint
{
    [HttpDelete("heartRate/{id}")]
    public async Task ExecuteAsync(
        [FromServices] IHeartRateRepository heartRateRepository,
        [FromRoute] int id)
    {
        await heartRateRepository.DeleteHeartRateAsync(id);
    }
}