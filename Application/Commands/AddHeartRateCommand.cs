using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Commands;

public sealed class AddHeartRateAsync : HttpEndpoint
{
    [HttpPost("heartRate")]
    public async Task ExecuteAsync(
        [FromServices] IHeartRateRepository heartRateRepository,
        [FromBody] HeartRate heartRate)
    {
        await heartRateRepository.AddHeartRateAsync(heartRate);
    }
}