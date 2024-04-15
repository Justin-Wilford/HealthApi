using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Queries;

public sealed class GetHeartRateByIdQuery : HttpEndpoint
{
    [HttpGet("HeartRate/{HeartRateId}")]
    public async Task<HeartRate?> ExecuteAsync(
        [FromServices] IHeartRateRepository heartRateRepository,
        [FromRoute] int HeartRateId)
    {
        var heartRate = heartRateRepository.GetHeartRateByIdAsync(HeartRateId);

        return await heartRate;
    }
}